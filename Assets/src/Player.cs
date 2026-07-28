using UnityEngine;

public class Player : MonoBehaviour {
    
    Rigidbody2D rb;

    public float move_speed = 6f;

    void Start() {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update() {

        rb.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * move_speed, rb.linearVelocity.y);

    }

}
