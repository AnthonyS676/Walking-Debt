using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public float Speed;
    private float distance;
    public float Max;
    public Vector2 height;
    public Animator anim;

    PatrolingEnemys patrolingEnemys;
    private void Start()
    {
        patrolingEnemys = GetComponent<PatrolingEnemys>();
        target = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void Update()
    {
        bool moving = true;
        distance = Vector2.Distance(target.transform.position, transform.position);
        if (distance <= Max)
        {
            transform.position = Vector2.MoveTowards(transform.position, height, Speed * Time.deltaTime);
            //wall.gameObject.SetActive(false);
            patrolingEnemys.enabled = false;
        }
        anim.SetBool("Walking", moving);
    }
}
