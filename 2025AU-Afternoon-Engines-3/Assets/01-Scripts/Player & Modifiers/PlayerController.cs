using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public static PlayerController instance;

    public float spellPowerMod = 1f;
    [Header("Movement")]
    public float moveSpeed = 7.15f;
    private float defaultMoveSpeed;
    [HideInInspector] public float groundDrag = 5f;
    public float jumpForce = 6f;
    [HideInInspector] public float jumpCooldown = 0.25f;
    public float airVelocityMultiplier = 1.05f;
    private float defaultAirVelocityMultiplier;
    [HideInInspector] public bool readyToJump = true;
    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space; // TODO: allow to be customized in controls later-on
    [Header("Ground Check")]
    public float playerHeight = 2;
    public LayerMask whatIsGround;
    private bool isGrounded;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDirection;
    private Rigidbody rb;
    [HideInInspector] private  bool enabledSpeedEffect = false;

    [Header("Spell Status")]
    public string currentlyEquippedSpell;
    [HideInInspector] public bool speedActive = false;
    // private bool FlightActive = false;
    // private bool GravityActive = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
        instance = this;
        defaultMoveSpeed = moveSpeed;
        defaultAirVelocityMultiplier = airVelocityMultiplier;
    }

    private void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        GetPlayerInput();
        SpeedControl();
        if (isGrounded)
        {
            rb.linearDamping = groundDrag;
        }
        else
        {
            rb.linearDamping = 0;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            ActivateCurrentSpell();
        }
        if (!speedActive && enabledSpeedEffect)
        {
            moveSpeed = defaultMoveSpeed;
            enabledSpeedEffect = false;
            airVelocityMultiplier = defaultAirVelocityMultiplier;
        }
    }
    private void FixedUpdate()
    {
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

        if (isGrounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if (!isGrounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airVelocityMultiplier, ForceMode.Force);
        }
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
    {
        readyToJump = true;
    }
    public  void SpeedModifier(float speedModMulti)
    {
        float appliedSpeedModMulti = speedModMulti;
        speedActive = true;
        moveSpeed *= appliedSpeedModMulti;
        airVelocityMultiplier *= 1 + appliedSpeedModMulti * 0.15f;
        enabledSpeedEffect = true;
    }
    public void ActivateCurrentSpell()
    {
        GameObject heldSpell = SpellSelector.instance.GetCurrentHeldSpell();
        if (heldSpell == null)
        {
            Debug.LogWarning("No spell is currently held!");
            return;
        }

        SpellBase spell = heldSpell.GetComponent<SpellBase>();
        if (spell != null)
        {
            spell.ActivateSpell();
        }
        else
        {
            Debug.LogWarning("Held spell does not have a SpellBase component!");
        }

        Destroy(heldSpell);
    }
}