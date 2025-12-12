using UnityEngine;
using UnityEngine.UIElements;

public class PlatformMovement : MonoBehaviour
{
    Transform transformPlatform;
    private Vector3 initialPosition;
    private Vector3 finalPosition;
    [SerializeField] private float initialY;
    [SerializeField] private float finalY;
    private Vector3 position;
    private float speed = 5;
    [SerializeField] private bool topDestination = false;
    void Start()
    {
        transformPlatform = GetComponent<Transform>();
        initialPosition = new Vector3(transform.position.x, initialY, transform.position.z);
        finalPosition = new Vector3(transform.position.x, finalY, transform.position.z);
    }
    void FixedUpdate()
    {
        if (topDestination == false)
        {
            transformPlatform.position = Vector3.MoveTowards(transformPlatform.position, finalPosition, speed * Time.deltaTime);
            if (Vector3.Distance(transformPlatform.position, finalPosition) < 0.01f)
            {
                topDestination = true;
            }
        }
        else
        {
            transformPlatform.position = Vector3.MoveTowards(transformPlatform.position, initialPosition, speed * Time.deltaTime);
            if (Vector3.Distance(transformPlatform.position, initialPosition) < 0.01f)
            {
                topDestination = false;
            }
        }
    }
}
