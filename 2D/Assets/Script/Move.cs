using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
    }
}

