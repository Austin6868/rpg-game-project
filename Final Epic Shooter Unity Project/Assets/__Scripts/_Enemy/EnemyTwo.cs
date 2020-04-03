using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
//intereted from the base enemy class
public class EnemyTwo :Enemy
{

    private AIPath aiPath;
    public int maxHealth;
    public GameObject fireBall;

    void Start()
	{
        InvokeRepeating("Shoot",2f,2f);
    }
    
    protected override void Update()
    {
        //this is a library that is implemented for the Ai in the game and this is for the flipping the sprite of the enemy
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
            Instantiate(fireBall,new Vector3(transform.position.x , transform.position.y , 91f), Quaternion.identity);//the shooting of the enemy towards the player
    }


    protected override void OnTriggerEnter2D(Collider2D other)//enemy getting hit by the bullets and suffers a greater damage by sniper rifles
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
