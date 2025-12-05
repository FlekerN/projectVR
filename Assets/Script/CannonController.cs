using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CannonController : MonoBehaviour
{
    public AudioSource audioSource;
    public XRSocketInteractor socket;
    public Transform puntaCannon;
    public float fuerzaDisparo = 75f;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Shot() 
    {
        if (!socket.hasSelection)
        {
            Debug.Log("No hay bala en el cañón.");
        }else
        {
            audioSource.Play();
            IXRSelectInteractable interactable = socket.firstInteractableSelected;
            GameObject cannonBall = interactable.transform.gameObject;

            socket.interactionManager.CancelInteractableSelection(interactable);

            cannonBall.GetComponent<XRGrabInteractable>().enabled = false;
  
            Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
            cannonBall.transform.position = puntaCannon.position + puntaCannon.forward * 0.2f;

            rb.AddForce(puntaCannon.forward * fuerzaDisparo, ForceMode.Impulse);
        }
    }
}
