using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    bool facingLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision != null){
            facingLeft = !facingLeft;
        }

        if(facingLeft){
            gameObject.transform.rotation = Quaternion.Euler(0,0,0);
        }else{
            gameObject.transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}
