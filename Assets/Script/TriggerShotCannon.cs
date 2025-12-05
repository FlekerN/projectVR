using UnityEngine;

public class TriggerShotCannon : MonoBehaviour
{    
    public CannonController Cannon;
    public void OnTriggerEnter(Collider collider) 
    {
        TorchController torch = collider.GetComponent<TorchController>();

        if(collider.CompareTag("Torch") && torch.isOnFire)
        {
            Cannon.Shot();
        }
    }
}
