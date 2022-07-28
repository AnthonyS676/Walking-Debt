using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Rigidbody2D projectile1;

    public float speed = 20;
    Crystal Thecrystal;
    bool ShootPink = false;
    public GameObject arm;
    public AudioSource audioSource;


    // Use this for initialization
    void Start()
    {

        Thecrystal = GetComponent<Crystal>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (Thecrystal.count > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ShootPink = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ShootPink = !ShootPink;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                audioSource.Play();
                arm.SetActive(true);
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 shootdir = mousePos - transform.position;
                shootdir = shootdir.normalized;
                Rigidbody2D bullet = ShootPink ? projectile1 : projectile;
                Rigidbody2D instantiatedProjectile = Instantiate(bullet, transform.position + shootdir , transform.rotation) as Rigidbody2D;
                instantiatedProjectile.velocity = shootdir * speed;
                Thecrystal.count -= ShootPink ? 5: 1;
                Thecrystal.countText.text = "Total Coins: " + Thecrystal.count;
            }
        }
        
    }
}
