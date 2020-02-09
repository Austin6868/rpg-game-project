using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10.0f;
    public float jumpSpeed = 20.0f;
    public bool isGrounded = false;

   void Start()
    {
       
    }
    void Update()
    {
        Jump();

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
        }
    }
}