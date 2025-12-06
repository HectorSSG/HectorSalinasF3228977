using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject creditsPanel;

    private GameObject currPanel;
    public void Start()
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
    public void BackButton()
    {
        if (currPanel == optionsPanel || currPanel == creditsPanel)
        {
            if (currPanel == optionsPanel)
            {
                ChangePanel(mainPanel);
            }
            else if (currPanel == creditsPanel)
            {
                ChangePanel(mainPanel);
            }
        }
    }
    public void ChangePanel(GameObject newPanel)
    {
        currPanel.SetActive(false);
        newPanel.SetActive(true);
        currPanel = newPanel;
    }
}
