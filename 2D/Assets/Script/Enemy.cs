using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public float Speed;
    public GameObject wall;
    private float distance;
    public float Max;

    PatrolingEnemys patrolingEnemys;
    private void Start()
    {
        patrolingEnemys = GetComponent<PatrolingEnemys>();
        target = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void Update()
    {
        distance = Vector2.Distance(target.transform.position, transform.position);
        if (distance <= Max)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
            wall.gameObject.SetActive(false);
            patrolingEnemys.enabled = false;
        }
    }
}
