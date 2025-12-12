using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionZone : MonoBehaviour
{
    [SerializeField] private string newScene;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(newScene);
        }
    }
}