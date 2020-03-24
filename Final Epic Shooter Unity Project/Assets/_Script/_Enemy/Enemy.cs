using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player other1;

    private int scoreHere;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        other1 = FindObjectOfType<Player>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {//On trigger enter method that detects the collision between the player and the enemy
        if (other.gameObject.tag == "Player")
        {//the if statement varifies whether the object is the desired enemy kill
           gameObject.SetActive(false);
           Debug.Log("Triggered");
           other1.TakeDamage(20);
        }
        if (other.gameObject.tag == "Bullet")
		{
            other1.score++;
            Destroy(gameObject);
            
        }
       
    }
}
