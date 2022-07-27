using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escape : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Game;

    private void Awake()
    {
        Text1.SetActive(true);
        Invoke("text", 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void text()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        Invoke("text2", 7.0f);
    }
    void text2()
    {
        Text2.SetActive(false);
        Game.SetActive(true);
    }

}
