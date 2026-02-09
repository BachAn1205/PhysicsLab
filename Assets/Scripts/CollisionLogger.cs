using UnityEngine;
public class CollisionLogger : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(gameObject.name + " va chạm với " + other.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(gameObject.name + " đi qua Trigger " + other.gameObject.name);
    }
}