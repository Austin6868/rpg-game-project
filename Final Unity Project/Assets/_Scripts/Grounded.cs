using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
        // Allows us to acces the player to check if it is grounded later.
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Player.GetComponent<Movement2D>().isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Movement2D>().isGrounded = false;

        }
    }
}
