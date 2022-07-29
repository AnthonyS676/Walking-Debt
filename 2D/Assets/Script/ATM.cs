using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ATM : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Play();
            SceneManager.LoadScene("YouWin");
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        audioSource.Play();
            SceneManager.LoadScene("YouWin");

       
    }
}
