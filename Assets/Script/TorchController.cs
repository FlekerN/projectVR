using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
public class TorchController : MonoBehaviour
{
    public XRGrabInteractable Hand;
    public GameObject fire;
    public bool isOnFire = false;

    private void Awake()
    {
        fire.SetActive(false);
        Hand = GetComponent<XRGrabInteractable>();
        Hand.selectEntered.AddListener(StarFire);
        Hand.selectExited.AddListener(StopFire);
    }

    public void StarFire(SelectEnterEventArgs data) 
    {
        isOnFire = true;
        fire.SetActive(true);
        ParticleSystem fireparticle = fire.GetComponent<ParticleSystem>();
        fireparticle.Play();
    }
    public void StopFire(SelectExitEventArgs data)
    {
        isOnFire = false;
        fire.SetActive(false);
        ParticleSystem fireparticle = fire.GetComponent<ParticleSystem>();
        fireparticle.Stop();
    }
}
