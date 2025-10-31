using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public static PlayerController instance;
    [Header("Movement")]

    public static float moveSpeed = 7.15f;
    readonly private float defaultMoveSpeed = 7.15f;
    public float groundDrag = 5f;
    public float jumpForce = 6f;
    public float jumpCooldown = 0.25f;
    public float airMultiplier = 0.4f;
    [HideInInspector] public bool readyToJump = true;
    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space; // TODO: allow to be customized in controls later-on
    [Header("Ground Check")]
    public float playerHeight = 2;
    public LayerMask whatIsGround;
    private bool grounded;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDirection;
    private Rigidbody rb;
    [Header("Spell Status")]
    private bool SpeedActive = false;
    [HideInInspector] public float SpeedDuration = 12f;
    private bool FlightActive = false;
    [HideInInspector] public float FlightDuration = 5f; 
    private bool GravityActive = false;
    [HideInInspector] public float GravityDuration = 8f; 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
        instance = this;
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        GetPlayerInput();
        SpeedControl();
        if (grounded)
        {
            rb.linearDamping = groundDrag;
        }
        else
        {
            rb.linearDamping = 0;
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

        if (Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }
    private void MovePlayer()
    {
        moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);

        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
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
    public void SpeedModifier(float speedModMulti)
    {
        SpeedActive = true;
        moveSpeed *= speedModMulti;
        
    }
}