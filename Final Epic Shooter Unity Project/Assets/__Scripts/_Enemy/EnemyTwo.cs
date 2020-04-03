using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyTwo :Enemy
{

    private AIPath aiPath;
    public int maxHealth;


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
    }


    

}
