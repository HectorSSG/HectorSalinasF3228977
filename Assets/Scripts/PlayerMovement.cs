using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalMovement;
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private bool isGround;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float radiusGround;
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocityX, jumpForce);
        }
    }
    private void FixedUpdate()
    {
        rigidBody.linearVelocity = new Vector2(horizontalMovement * speed, rigidBody.linearVelocityY);
        isGround = Physics2D.OverlapCircle(groundCheck.position, radiusGround, groundLayer);
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(groundCheck.position, radiusGround);
    }
}
