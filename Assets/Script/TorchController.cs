using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
public class TorchController : MonoBehaviour
{
    public XRGrabInteractable Hand;
    public GameObject fire;
    public bool isOnFire = false;
    public ParticleSystem fireparticle;

    private void Awake()
    {
        fireparticle = fire.GetComponent<ParticleSystem>();
        fire.SetActive(false);
        Hand = GetComponent<XRGrabInteractable>();
        Hand.activated.AddListener(OnActivated);
        Hand.deactivated.AddListener(OnDeactivate);
    }

    public void OnActivated(ActivateEventArgs data) 
    {
        isOnFire = true;
        fire.SetActive(true);
        fireparticle.Play();
    }
    public void OnDeactivate(DeactivateEventArgs data)
    {
        isOnFire = false;
        fire.SetActive(false);
        fireparticle.Stop();
    }
}
