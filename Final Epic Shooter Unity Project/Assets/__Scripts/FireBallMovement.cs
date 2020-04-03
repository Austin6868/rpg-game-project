using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMovement : MonoBehaviour
{
    private Vector3 target;
    private Player other1;

    void Start()
    {
        other1 = FindObjectOfType<Player>();//find the position of the player
        target = new Vector3 (GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y,91);
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);//make a fireball that goes towards the player at a reasonable speed
        if (transform.position.x == target.x && transform.position.y == target.y)
		{
            Destroy(gameObject);
		}
        
    }
    void OnTriggerEnter2D(Collider2D other)//the player takes damaga when hit
	{
        if (other.gameObject.tag == "Player")
		{
            other1.TakeDamage(30);
            Destroy(gameObject);
        }
	}
}
