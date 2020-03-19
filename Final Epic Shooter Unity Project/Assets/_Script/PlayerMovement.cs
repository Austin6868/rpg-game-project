using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Vector2 movement;

    public Rigidbody2D rb;
    public Animator animator;



    public void Update()
    {
        Move();
    }

    public virtual void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Move()
	{
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x == movement.y || movement.x == -movement.y)
        {
            movement.x = movement.x / Mathf.Sqrt(2f);
            movement.y = movement.y / Mathf.Sqrt(2f);
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
