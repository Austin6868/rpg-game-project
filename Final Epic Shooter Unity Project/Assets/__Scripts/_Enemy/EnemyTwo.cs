using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyTwo :Enemy
{

    private AIPath aiPath;
    public int maxHealth;
    public GameObject fireBall;

    void Start()
	{
        InvokeRepeating("Shoot",2f,2f);
    }
    // Update is called once per frame
    protected override void Update()
    {
        
        aiPath = gameObject.GetComponent<AIPath>();
        if (aiPath.desiredVelocity.x >= 0.01f) 
		{
            transform.localScale = new Vector3(1f,1f,1f);
		}else if (aiPath.desiredVelocity.x <= -0.01f)
		{
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (maxHealth <= 0)
		{
            gameObject.SetActive(false);
            Equipment.E.exp += 500;
            CancelInvoke();

        }
    }
    void Shoot()
    { 
            Instantiate(fireBall,new Vector3(transform.position.x , transform.position.y , 91f), Quaternion.identity);
    }


    protected override void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Bullet") && Equipment.E.EG == 2)
		{
            maxHealth -= 200;
		}
        if (other.gameObject.CompareTag("Bullet"))
		{
            maxHealth -= 50;
		}
        
        
    }

}
