using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void game()
    {
        SceneManager.LoadScene("Level1");
    }
}
