using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private void Start()
    {

    }
    public void ChangeScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
    public void ExitGame()
    {
        Debug.Log("Salió del juego");
        Application.Quit();
    }
}
