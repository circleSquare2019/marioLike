using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float moveInput;
    public Rigidbody2D rb;
    public float speed;
    public Transform pos;
    public float radius;
    public LayerMask groundLayers;
    public float jumpForce;
    public float heightCutter;
    bool grounded;
    bool dead;

    void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        dead=false;
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(!dead){
            moveInput = Input.GetAxis("Horizontal");
            grounded = Physics2D.OverlapCircle(pos.position, radius, groundLayers);

            if(grounded && Input.GetKeyDown(KeyCode.Space)){
                rb.velocity = Vector2.up * jumpForce;
            }

            if(Input.GetKeyUp(KeyCode.Space)){
                if(rb.velocity.y > 0){
                    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * heightCutter);
                }
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.collider.CompareTag("Enemy")){
            dead=true;
            speed=0;
            Destroy(this.gameObject);
        }
    }
}
