using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 initialPosition;
    private void Start()
    {
        initialPosition = playerTransform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerTransform.position = initialPosition;
    }
}
