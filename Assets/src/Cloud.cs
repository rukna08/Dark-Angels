using UnityEngine;

public class Cloud : MonoBehaviour {
    

    public float move_speed = 2f;
    public float size = 5f;

    void Start() {

        size = Random.Range(5f, 10f);

        transform.localScale = new Vector2(size, size);

    }


    void Update() {

        transform.position = new Vector2(transform.position.x + move_speed, transform.position.y);

    }


}
