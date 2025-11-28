using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ShocketController : MonoBehaviour
{
    private bool tienellave;

    private void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
        XRSocketInteractor xr = GetComponent<XRSocketInteractor>();
        xr.hoverEntered.AddListener(hover);
        xr.selectEntered.AddListener(usar);
        xr.selectExited.AddListener(salir);
        xr.hoverExited.AddListener(sacar);
        tienellave = false;
    }
    private void hover(HoverEnterEventArgs data)
    {
        if(!tienellave)
            GetComponent<Renderer>().material.color = Color.blue;
        
    }

    public void usar(SelectEnterEventArgs data) 
    {
        if (!tienellave) 
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            tienellave = true;
        }

    }

    public void sacar(HoverExitEventArgs data) 
    {
        if(!tienellave)
            GetComponent<Renderer>().material.color = Color.white;
    }

    public void salir(SelectExitEventArgs data)
    {
        tienellave = false;
    }
}
