using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolingEnemys : MonoBehaviour
{
    public float MovementSpeed = 3.0f;
    public bool bIsGoingRight = true;
   
    private SpriteRenderer _mSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _mSpriteRenderer.flipX = bIsGoingRight;
    }


    void Update()
    {
        Vector3 directionTranslation = (bIsGoingRight) ? transform.right : -transform.right;
        directionTranslation *= Time.deltaTime * MovementSpeed;

        transform.Translate(directionTranslation);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            bIsGoingRight = !bIsGoingRight;
            _mSpriteRenderer.flipX = bIsGoingRight; bIsGoingRight = !bIsGoingRight;
        }
    }
}