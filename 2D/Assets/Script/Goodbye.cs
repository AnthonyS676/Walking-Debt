using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Goodbye : MonoBehaviour
{
    public int health;
    
    public DeathCounter deathCounter;
    void Start()
    {
       
        //health = 100;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            health -= 5;
            Debug.Log("Hit");
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet1"))
        {
            health -= 10;
            Debug.Log("Hit");
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("bullet2"))
        {
            health -= 20;
            Debug.Log("Hit");
            collision.gameObject.SetActive(false);
        }
        if (health <= 0)
        {
            gameObject.SetActive(false);
            
            deathCounter.IncreaseDeathCount();
        }
    }
}
