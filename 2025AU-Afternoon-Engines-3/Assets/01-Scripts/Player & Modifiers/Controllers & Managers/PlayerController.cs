using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public static PlayerController instance;
    [Header("Movement & Stats")]
    public float spellPowerMod = 1f;
    public float moveSpeed = 5.25f, currentHealth = 1, maxHealth = 100, jumpForce = 6f, airVelocityMultiplier = 1.05f, groundDrag = 5f;    
    private float defaultMoveSpeed, jumpCooldown = 0.25f, defaultAirVelocityMultiplier, playerHeight = 2, horizontalInput, verticalInput, unstickDelay = 0.85f, timeSinceGrounded = 0f;
    [HideInInspector] public bool readyToJump = true, speedActive = false;
    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    [Header("Ground Check")]
    public LayerMask whatIsGround;
    private bool isGrounded, enabledSpeedEffect = false, isMenuOpen = false;
    private Vector3 moveDirection;
    private Rigidbody rb;
    [Header("Spell Status")]
    public string currentlyEquippedSpell;
    [Header("Poses")]
    public GameObject Pose1; 
    public GameObject Pose2, Pose3, Pose4, parchmentMenu;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
        if(instance == null)
        {
            instance = this;
        }
        else
        { if(instance != this)
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        defaultMoveSpeed = moveSpeed;
        defaultAirVelocityMultiplier = airVelocityMultiplier;
    }

    private void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        if (isGrounded) timeSinceGrounded = 0f;
        else timeSinceGrounded += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Tab))
            ToggleSpellMenu();

        if (isMenuOpen)
            return;

        GetPlayerInput();
        SpeedControl();
        rb.linearDamping = isGrounded ? groundDrag : 0;

        if (Input.GetButtonDown("Fire1"))
            ActivateCurrentSpell();

        if (!speedActive && enabledSpeedEffect)
        {
            moveSpeed = defaultMoveSpeed;
            airVelocityMultiplier = defaultAirVelocityMultiplier;
            enabledSpeedEffect = false;
        }
    }
    public void ToggleSpellMenu()
    {
        if (parchmentMenu == null)
        {
            Debug.LogWarning("Parchment Canvas not assigned in PlayerController!");
            return;
        }

        // Toggle menu state
        isMenuOpen = !isMenuOpen;
        parchmentMenu.SetActive(isMenuOpen);

        // Manage cursor & camera
        if (isMenuOpen)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            CameraController.instance.cameraCanMove = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            CameraController.instance.cameraCanMove = true;
        }

        // Enable or disable player control *once*
        ToggleMovementStatus(!isMenuOpen);
    }
    private void FixedUpdate()
    {
        if (!isMenuOpen)
            MovePlayer();
    }
    private void GetPlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(jumpKey) && readyToJump && isGrounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }
    private void MovePlayer()
    {
        moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);
        moveDirection.Normalize();

        RaycastHit wallHit;
        bool hitWall = Physics.Raycast(transform.position, moveDirection, out wallHit, 0.5f, whatIsGround);


        if (hitWall && !isGrounded && timeSinceGrounded > unstickDelay)
        {
            moveDirection = Vector3.ProjectOnPlane(moveDirection, wallHit.normal).normalized;

            Vector3 vel = rb.linearVelocity;
            if (vel.y >= -1f)
            {
                vel.y = -1f;
                rb.linearVelocity = vel;
            }
        }
        if (isGrounded)
        { rb.AddForce(moveDirection * moveSpeed * 10f, ForceMode.Force);}
        else
        { rb.AddForce(moveDirection * moveSpeed * 10f * airVelocityMultiplier, ForceMode.Force); }
        Debug.DrawRay(transform.position, moveDirection * 0.5f, hitWall ? Color.red : Color.green);
    }
    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        if (flatVelocity.magnitude > moveSpeed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVelocity.x, rb.linearVelocity.y, limitedVelocity.z);
        }
    }
    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {readyToJump = true;}
    public void SpeedModifier(float speedModMulti) 
    {
        float appliedSpeedModMulti = speedModMulti;
        speedActive = true;
        Debug.Log("Speed Active");
        moveSpeed *= appliedSpeedModMulti;
        airVelocityMultiplier *= 1 + appliedSpeedModMulti * 0.15f;
        enabledSpeedEffect = true;
    }
    public void ActivateCurrentSpell()
    {
        GameObject heldSpell = SpellSelector.instance.GetCurrentHeldSpell();
        if (heldSpell == null)
        {
            currentlyEquippedSpell = SpellSelector.instance.currentSpellName;
            return; }

        SpellBase spell = heldSpell.GetComponent<SpellBase>();
        if (spell != null)
        { spell.ActivateSpell(); }


        Destroy(heldSpell);
    }

    public void ToggleMovementStatus(bool enableMovement)
    {
        if (enableMovement)
        {
            if (!enabledSpeedEffect)
            {
                moveSpeed = defaultMoveSpeed;
                rb.linearDamping = 1f;
            }        
        }
        else
        {
            rb.linearVelocity = Vector3.zero;
            rb.linearDamping = 4f;
            moveSpeed = 0f;
            if (!enabledSpeedEffect)
            {
                moveSpeed = defaultMoveSpeed;
                rb.linearDamping = 1f;
            }        
        }
    }
}