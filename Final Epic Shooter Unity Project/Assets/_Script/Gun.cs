using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Vector3 position;
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject player;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Transform playerTransform = player.transform;
        // get player position
        position = playerTransform.position;
        position.y = position.y - 0.2f;
        position.x = position.x + 0.05f;
        
        Debug.Log(position);
        transform.position = position;
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        Debug.Log(angle);
        if (angle >90f || angle< -90f)
		{
            position.y = position.y + 0.1f;
            position.x = position.x - 0.1f;
            
            
		}
        transform.position = position;
        rb.rotation = angle;
    }
}
