using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BÁO ĐỘNG! Vật thể " + other.name + " đã xâm nhập vùng cấm!");

        Renderer objectRenderer = other.GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " đã rời khỏi vùng an toàn.");
    }
}