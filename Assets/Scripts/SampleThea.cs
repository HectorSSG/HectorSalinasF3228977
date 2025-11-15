using UnityEngine;

public class SampleThea : MonoBehaviour
{
    [SerializeField] private int funds;
    [SerializeField] private int cover;
    [SerializeField] private int bottlePrice;
    [SerializeField] private bool gatecrash = false;
    [SerializeField] private bool findOut = false;

    private void Start()
    {
        if (cover <= funds)
        {
            Debug.Log("Entran los hptas enanos.");
            funds = funds - cover;
            if (bottlePrice <= funds)
            {
                Debug.Log("Compran una botella.");
                funds = funds - bottlePrice;
            }
            else
            {
                Debug.Log("No compran la botella");
            }
        }
        else
        {
            Debug.Log("No entran tetranutras enanos");
            if (gatecrash == true)
            {
                Debug.Log("Enanitos verdes trabados");
                if (findOut == true)
                {
                    Debug.Log("Explotación de enanos");
                }
                else
                {
                    Debug.Log("Proyectico x");
                }
            }
            else
            {
                Debug.Log("Se van a pajearse en la casa");
            }
        }
    }
}
