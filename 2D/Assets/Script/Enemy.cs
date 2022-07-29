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
<<<<<<< HEAD
            transform.position = Vector2.MoveTowards(transform.position, height, Speed * Time.deltaTime);
            //wall.gameObject.SetActive(false);
            //patrolingEnemys.enabled = false;
        }
        //anim.SetBool("Walking", moving);
=======
            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
>>>>>>> 4ded6f5e006f5b4190643d8349da90842f5a9756
    }

    void Update()
    {
        if (target == null)
            return;
        transform.LookAt(target);
        float distance = Vector2.Distance(transform.position, target.position);
        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}