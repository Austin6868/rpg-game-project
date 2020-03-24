using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPoint : MonoBehaviour
{
    public GameObject player;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        Transform playerTransform = player.transform;
        position = playerTransform.position;
        gameObject.SetActive(true);
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
        if ((Input.GetAxisRaw("Vertical") == -1 && Input.GetAxisRaw("Horizontal") == -1 )|| (Input.GetAxisRaw("Vertical") == -1 && Input.GetAxisRaw("Horizontal") == -1) ||(Input.GetAxisRaw("Vertical") == 1&& Input.GetAxisRaw("Horizontal") == -1)|| (Input.GetAxisRaw("Vertical") == 1 && Input.GetAxisRaw("Horizontal") == 1))
		{
            position.y = position.y;
            position.x = position.x ;
            position.z = 0;
        }
        transform.position = position;

    }
}
