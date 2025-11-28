using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

[RequireComponent(typeof(XRGrabInteractable))]
public class ShotgunController : MonoBehaviour
{
    public XRGrabInteractable Hand;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Hand = GetComponent<XRGrabInteractable>();
        Hand.activated.AddListener(Disparar);
        
    }

    public void Disparar(ActivateEventArgs data) 
    {
        Debug.Log("Pium");
        audioSource.Play();
        data.interactorObject.transform.GetComponent<XRBaseInputInteractor>().SendHapticImpulse(0.7f, 0.7f);

        if (data.interactorObject is XRBaseInputInteractor controller)
        {
            controller.SendHapticImpulse(0.7f, 0.7f);
        }

        //raycast
        //haptic
        //activar animacion
    }
}
