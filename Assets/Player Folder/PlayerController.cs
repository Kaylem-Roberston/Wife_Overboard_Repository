using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float moveSpeed;
    public float jumpForce;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public bool isGrounded;

    private float inputX;

    void Start()
    {
        
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(inputX));

        if (Mathf.Abs(inputX) > 0)
        {
            float direction = Mathf.Sign(inputX);
            transform.localScale = new Vector3(direction * 2, 2, 2);
        }
        

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.linearVelocityY = jumpForce;
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocityX = inputX * moveSpeed;
    }
}
