using System;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    [SerializeField] private int x;
    [SerializeField] private int y;
    private int r;
    void Start()
    {
        r = x * y;
        Debug.Log("El resultado es: " + r);
    }
    void Update()
    {
        Debug.LogError("No sirve ñro");
    }
}
