using UnityEngine;

public class ForcePusher : MonoBehaviour
{
    public float pushForce = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 1) * pushForce, ForceMode.Impulse);
        }
    }
}