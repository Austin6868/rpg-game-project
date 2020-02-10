using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public float jumpSpeed = 20.0f;
    private float moveInput;
   
    private Rigidbody2D rb;
    
    private bool facingRight = true;

    public Transform groundDetect;
    public bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;

    public int doubleJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundDetect.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(facingRight == false && moveInput > 0)
        {
            Flip();
        } else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }

        // Allows the player to move left and right. Flip() calls in an if/else allows flip to be called when
        // the player begins moving left or right.

    }

    void Update()
    {
        if(isGrounded == true){
            doubleJump = 1;
        }

        if (Input.GetButtonDown("Jump") && doubleJump == 1)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            doubleJump--;
        } else if(Input.GetButtonDown("Jump") && doubleJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scalePiece = transform.localScale;
        scalePiece.x *= -1;
        transform.localScale = scalePiece;

        // Ask TA/Prof about flipping bullet spawn. Could use transform.Rotate(0, 180f, 0); but that messes with decal.

        // Allows the player Sprite to flip when moving from the right to the left.
    }

    
}
 