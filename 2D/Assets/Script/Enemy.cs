using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    //public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    [SerializeField] Transform target;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (target == null)
            return;
        float distance = Vector2.Distance(transform.position, target.position);

        if (transform.position.x < target.position.x)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else if (transform.position.x > target.position.x)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }



        //position of landlord - position of character -> if value is negative then move right/ if positive move left


        /*
        float distance = Vector2.Distance(transform.position, target.positon);
        Debug.Log(distance);
        if (distance > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            transform.LookAt(target.position);
        }*/

    }
}
