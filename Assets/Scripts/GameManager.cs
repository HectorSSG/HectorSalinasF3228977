using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
        player.SetActive(true);
    }
    void Update()
    {

    }
}
