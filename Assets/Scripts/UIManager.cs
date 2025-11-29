using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject creditsPanel;
    
    private GameObject currPanel;
    private void Start()
    {
        currPanel = mainPanel;
    }
    public void ShowMainMenuPanel()
    {
        ChangePanel(mainPanel);
    }
    public void ShowOptionsPanel()
    {
        ChangePanel(optionsPanel);
    }
    public void ShowCreditsPanel()
    {
        ChangePanel(creditsPanel);
    }
    private void ChangePanel(GameObject newPanel)
    { 
        currPanel.SetActive(false);
        newPanel.SetActive(true);
        currPanel = newPanel;
    }
}
