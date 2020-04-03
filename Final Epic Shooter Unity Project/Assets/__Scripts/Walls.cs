using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");

    }

    void OnTriggerEnter2D(Collider2D col)
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
        if (col.gameObject.tag == "Player")
        {
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 1f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
