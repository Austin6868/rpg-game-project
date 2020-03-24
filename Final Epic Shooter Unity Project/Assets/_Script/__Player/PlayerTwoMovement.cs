using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : PlayerMovement
{
    public KeyCode[] combo;
    public int currentIndex = 0;
    
	public void LateUpdate()//this script handles when the player presses the space button, the player would teleport.
	{
        
        float x = transform.position.x;
        float y = transform.position.y;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            //the "Jump" button is assigned to "Space"
            if(movement.x == -1 && Input.GetButtonDown("Jump"))
			{
            
                transform.position = new Vector3(x - 1.5f, y, transform.position.z);
            
			}
			if(movement.x == 1 && Input.GetButtonDown("Jump"))
            {
            
                transform.position = new Vector3(x + 1.5f, y, transform.position.z);
            

            }
			if(movement.y == 1 && Input.GetButtonDown("Jump"))
			{
            
                transform.position = new Vector3(x, y + 1.5f, transform.position.z);
            
			}
			if (movement.y == -1 && Input.GetButtonDown("Jump"))
			{
            
                transform.position = new Vector3(x, y - 1.5f, transform.position.z);
            }
			}
        

    }

