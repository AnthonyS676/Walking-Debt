using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet1"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet2"))
        {
            collision.gameObject.SetActive(false);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet1"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet2"))
        {
            collision.gameObject.SetActive(false);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
