using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseAudio : MonoBehaviour
{
    public new AudioSource audio;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void game()
    {
        audio.Play();
        SceneManager.LoadScene("Level1");
    }
}
