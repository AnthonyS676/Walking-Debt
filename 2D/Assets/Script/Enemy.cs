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