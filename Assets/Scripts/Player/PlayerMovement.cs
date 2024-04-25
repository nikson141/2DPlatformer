using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;

    private float _horizontalInput;
    private bool _isFacingRight;
    private bool _isJumping;
    private int _jumpCount; // Track the number of jumps

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        _jumpCount = 0; // Initialize jump count
    }

    private void Update()
    {
        Movement();
        FlipPlayer();
        JumpPlayer();
    }

    public void Movement()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(_horizontalInput * moveSpeed, rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(_horizontalInput));
    }

    public void FlipPlayer()
    {
        if (_isFacingRight && _horizontalInput > 0f || !_isFacingRight && _horizontalInput < 0)
        {
            _isFacingRight = !_isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }

    public void JumpPlayer()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!_isJumping)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0f); // Reset vertical velocity before jumping
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                _isJumping = true;
                _jumpCount++;
            }
            else if (_jumpCount < 2) // Allow double jump
            {
                rb.velocity = new Vector2(rb.velocity.x, 0f); // Reset vertical velocity before jumping
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                _jumpCount++;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isJumping = false;
            _jumpCount = 0; // Reset jump count when grounded
        }
    }
}
