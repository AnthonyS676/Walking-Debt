using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D projectile;

    public float speed = 20;
    Crystal Thecrystal;


    // Use this for initialization
    void Start()
    {
        Thecrystal = GetComponent<Crystal>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Thecrystal.count > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 shootdir = mousePos - transform.position;
                shootdir = shootdir.normalized;

                Rigidbody2D instantiatedProjectile = Instantiate(projectile, transform.position + shootdir , transform.rotation) as Rigidbody2D;
                instantiatedProjectile.velocity = shootdir * speed;
                Thecrystal.count -= 1;
                Thecrystal.countText.text = "Total Coins: " + Thecrystal.count;

            }
        }
    }
}
