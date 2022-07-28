using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Crystal : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int count;
    public AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
   
        countText.text = "Total Coins: " + count;
        PlayerPrefs.SetInt("count", count);
    }
    private void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
       {
        //Debug.Log("Works2");

        if (other.gameObject.CompareTag("Coin"))
        {
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Total Coins: " + count;
            //Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin1"))
        {
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 5;
            countText.text = "Total Coins: " + count;
            //Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin2"))
        {
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 10;
            countText.text = "Total Coins: " + count;
            //Debug.Log("Works");
        }
        if (other.gameObject.CompareTag("Coin3"))
        {
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 25;
            countText.text = "Total Coins: " + count;
            //Debug.Log("Works");
        }
    }

    
}