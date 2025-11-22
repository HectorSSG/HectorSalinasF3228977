using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private void Start()
    {

    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
