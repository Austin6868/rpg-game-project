using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player other1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        other1 = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {//On trigger enter method that detects the collision between the player and the pick up cube objects
        if (other.gameObject.tag == "Player")
        {//the if statement varifies whether the object is the desired cube pick up
           gameObject.SetActive(false);
           Debug.Log("Triggered");
           other1.TakeDamage(20);
        }
        if (other.gameObject.tag == "Bullet")
		{
            gameObject.SetActive(false);
        }
       
    }
}
