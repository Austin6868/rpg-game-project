using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPoint : MonoBehaviour
{
    public GameObject player;
    public Vector3 position;

    // Update is called once per frame
    //This script handles the ponint before the player that shows where the player is going to teleport to.
    void Update()
    {
        player = GameObject.Find("Player2(Clone)");
        Transform playerTransform = player.transform;
        position = playerTransform.position;
        gameObject.SetActive(true);
        //the z axis is set up within the visible distance of the camera
        if (Input.GetAxisRaw("Horizontal") == 1)
		{
            position.y = position.y;
            position.x = position.x + 1.5f;
            position.z = 103.0191f;
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            
            position.y = position.y;
            position.x = position.x - 1.5f;
            position.z = 103.0191f;
        }
        if (Input.GetAxisRaw("Vertical") == 1)
        {
            
            position.y = position.y + 1.5f;
            position.x = position.x ;
            position.z = 103.0191f;
        }
        if (Input.GetAxisRaw("Vertical") == -1)
        {
            
            position.y = position.y - 1.5f;
            position.x = position.x;
            position.z = 103.0191f;
        }
        if ((Input.GetAxisRaw("Vertical") == -1 && Input.GetAxisRaw("Horizontal") == -1 )|| (Input.GetAxisRaw("Vertical") == -1 && Input.GetAxisRaw("Horizontal") == 1) ||(Input.GetAxisRaw("Vertical") == 1&& Input.GetAxisRaw("Horizontal") == -1)|| (Input.GetAxisRaw("Vertical") == 1 && Input.GetAxisRaw("Horizontal") == 1))
		{
            position.y = position.y;
            position.x = position.x ;
            position.z = 0;
        }
        transform.position = position;

    }
}
