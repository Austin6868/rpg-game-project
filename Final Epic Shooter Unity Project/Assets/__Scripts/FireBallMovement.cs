using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMovement : MonoBehaviour
{
    private Vector3 target;
    private Player other1;
    // Start is called before the first frame update
    void Start()
    {
        other1 = FindObjectOfType<Player>();
        target = new Vector3 (GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y,91);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
		{
            Destroy(gameObject);
		}
        
    }
    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "Player")
		{
            other1.TakeDamage(30);
            Destroy(gameObject);
        }
	}
}
