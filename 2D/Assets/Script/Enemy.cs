using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 20.0f;
    public float minDist = 1f;
    public Transform target;
    void Start()
    {
        if (target == null)
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

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
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
