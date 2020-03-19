using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : PlayerMovement
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
	public override void FixedUpdate()
	{
        float x = transform.position.x;
        float y = transform.position.y;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
            if(Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x - 1f, y, transform.position.z);
            
			}
			if(Input.GetKeyDown(KeyCode.D)&& Input.GetKeyDown(KeyCode.Space))
            {
            
                transform.position = new Vector3(x + 1f, y, transform.position.z);
            

            }
			if(Input.GetKeyDown(KeyCode.W)&& Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x, y + 1f, transform.position.z);
            
			}
			if (Input.GetKeyDown(KeyCode.S)&& Input.GetKeyDown(KeyCode.Space))
			{
            
                transform.position = new Vector3(x, y - 1f, transform.position.z);
            }
			}
        

    }

