using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    
    //the collision detect of the bullet in which when it hits any wall it would be destroyed
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "FX")
        { }
		else
		{
            Destroy(gameObject);
        }
        
    }

}
