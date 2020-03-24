using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    
    //the collision detect of the bullet in which when it hits any wall it would be destroyed
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
