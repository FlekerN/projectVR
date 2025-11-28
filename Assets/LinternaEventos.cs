using System;
using UnityEngine;

public class LinternaEventos : MonoBehaviour
{
    public RectTransform ObjectUI;

    public GameObject Luz;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverEntered()
    {
        ObjectUI.gameObject.SetActive(true);
    }

    public void HoverExited()
    {
        ObjectUI.gameObject.SetActive(false);
    }

    public void Encender()
    {
        Luz.SetActive(true);
    }

    public void Apagar()
    {
        Luz.SetActive(false);
    }
}
