using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public coinCounter coinCounter;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.collider.CompareTag("Player")){
            coinCounter.AddCoin();
            Destroy(this.gameObject);
        }
    }
}
