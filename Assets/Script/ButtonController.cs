using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public bool isPressed = false;
    public GameObject button;
    public GameObject cannonBallPrefab;
    public GameObject torch;

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed) 
        {
            button.transform.localPosition = new Vector3(0,0.03f,0);
            GameObject sceneCannonBall =  GameObject.FindGameObjectWithTag("CannonBall");
            Destroy(sceneCannonBall);
           //nstantiate();
        }
    }
    private void OnTriggerExit(Collider other) 
    { 
        if (!isPressed) 
        {
            button.transform.localPosition = new Vector3(0, 0.15f, 0);
        } 
    }
}
