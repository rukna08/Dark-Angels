using UnityEngine;

public class Cloud : MonoBehaviour {    
    float move_speed;
    int size;

    void Start() {
        move_speed = Random.Range(0.5f, 2f);
        size = Random.Range(5, 20);
        transform.localScale = new Vector2(size, size);
    }

    void LateUpdate() {
        transform.position += Vector3.right * move_speed * Time.deltaTime;
    }
}