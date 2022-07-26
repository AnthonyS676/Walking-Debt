using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Crystal : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int count;


    private void Start()
    {
   
        countText.text = "Total Coins: " + count;

    }
    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
       {
        Debug.Log("Works2");

        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Total Coins: " + count;
            Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin1"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            countText.text = "Total Coins: " + count;
            Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin2"))
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            countText.text = "Total Coins: " + count;
            Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin3"))
        {
            other.gameObject.SetActive(false);
            count = count + 25;
            countText.text = "Total Coins: " + count;
            Debug.Log("Works");
        }
    }

    
}