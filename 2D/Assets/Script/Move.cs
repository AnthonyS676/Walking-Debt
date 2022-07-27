using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public LayerMask floors;
    public LayerMask player;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer rend;
    public float moveSpeed = 10.0f;
    public float jumpHeight = 0;
    void Start()
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        jumpHeight = 10;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpHeight = 25;   
    }
    void Update()
    {
        bool moving = false;
        bool air = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.flipX = true;
            moving = true;
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rend.flipX = false;
            moving = true;
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

        if (rb.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(3, 6, true);
            air = true;
        }
        else
        {
            Physics2D.IgnoreLayerCollision(3, 6, false);
            air = false;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Physics2D.IgnoreLayerCollision(3, 6, true);
        }

        anim.SetBool("Running", moving);
        anim.SetBool("Air", air);
    }
    
}

