using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionZone : MonoBehaviour
{
    public string newScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Entró");
            SceneManager.LoadScene(newScene);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player está adentro");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Salió");
        }
    }
}
