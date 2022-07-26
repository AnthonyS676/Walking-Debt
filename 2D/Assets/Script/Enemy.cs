using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public float Speed;

    private float distance;
    public float Max;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        distance = Vector2.Distance(target.transform.position, transform.position);
        if (distance <= Max)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
        }
    }
}
