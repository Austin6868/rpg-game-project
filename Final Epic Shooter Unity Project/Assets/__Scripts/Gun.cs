using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Vector3 position;
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject player;
    Vector2 mousePos;
    //the declaration for guns
    public Sprite Gun1;
    public Sprite Gun2;
    public Sprite Gun3;
    public Sprite Gun4;
    public Sprite Gun5;

    

    public Sprite[] spriteList = new Sprite[5];
    // Start is called before the first frame update
    void Start()
    {
        
        //the sprite list for guns
        spriteList[0] = Gun1;
        spriteList[1] = Gun2;
        spriteList[2] = Gun3;
        spriteList[3] = Gun4;
        spriteList[4] = Gun5;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player = GameObject.FindWithTag("Player");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Transform playerTransform = player.transform;
        // get player position
        position = playerTransform.position;
        position.y = position.y - 0.2f;
        position.x = position.x + 0.05f;
        
        
        transform.position = position;
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        
        if (angle >90f || angle< -90f)
		{
            position.y = position.y + 0.1f;
            position.x = position.x - 0.1f;
            
            
		}
        transform.position = position;
        rb.rotation = angle;
    }
    void LateUpdate()
    {
        Equip();
    }

    public void Equip()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Equipment.E.EG == i)
            {
                gameObject.GetComponent<Image>().sprite = spriteList[i];
            }
        }
    }
}
