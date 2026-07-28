using UnityEngine;

public class Player : MonoBehaviour {
    
    



    Rigidbody2D rb;

    public float move_speed = 6f;
    public float jump_speed = 10f;

    bool is_grounded;






    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        handle_input();
    }






    void handle_input() {

        // left and right
        if (is_grounded) {
            rb.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * move_speed, rb.linearVelocity.y);    
        }
        
        // jump
        if (Input.GetButtonDown("Jump") && is_grounded) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump_speed);
        }

    }




    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            is_grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            is_grounded = false;
        }
    }

}
