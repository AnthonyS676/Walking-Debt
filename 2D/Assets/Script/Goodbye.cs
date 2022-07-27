using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Goodbye : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI countText;
    public int dEATH;
    public GameObject ATM;
    void Start()
    {
        health = 100;
        countText.text = "Debts paid: " + dEATH;
        ATM.gameObject.SetActive(false);
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
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        
        if (health <= 0)
        {
            gameObject.SetActive(false);
            dEATH = dEATH + 1;
            countText.text = "Debts paid: " + dEATH;
            if (dEATH == 9)
            {
                ATM.gameObject.SetActive(true);
            }
        }


    }
}
