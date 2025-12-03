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
        Debug.Log("Se presionó opciones socio");
    }
    public void ShowCreditsPanel()
    {
        ChangePanel(creditsPanel);
        Debug.Log("Se presionó creditos socio");
    }
    public void BackButton()
    {
        if (currPanel == optionsPanel || currPanel == creditsPanel)
        {
            if (currPanel == optionsPanel)
            {
                Debug.Log("Regresa desde opciones socio");
            }
            else if (currPanel == creditsPanel)
            {
                Debug.Log("Regresa desde creditos socio");
            }
            ChangePanel(mainPanel);
        }
    }
    public void ChangePanel(GameObject newPanel)
    {
        currPanel.SetActive(false);
        newPanel.SetActive(true);
        currPanel = newPanel;
    }
}
