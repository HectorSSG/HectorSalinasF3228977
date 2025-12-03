using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float speed;
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
    }
}
