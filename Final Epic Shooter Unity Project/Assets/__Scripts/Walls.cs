using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{

    private GameObject player;



    void Update()
    {
        player = GameObject.FindWithTag("Player");

    }

    void OnTriggerEnter2D(Collider2D col)//this collider handles the opacity change of when the player enters the back of the building
	{
        if(col.gameObject.tag == "Player")
		{
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 0.4f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
	}
    void OnTriggerExit2D(Collider2D col)
	{
        if (col.gameObject.tag == "Player")//the building's alpha back to where it was after going out
        {
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 1f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
