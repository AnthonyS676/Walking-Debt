using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ATM : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("YouWin");
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
            SceneManager.LoadScene("YouWin");

       
    }
}
