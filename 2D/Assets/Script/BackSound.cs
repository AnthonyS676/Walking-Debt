using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSound : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] GameObject screen;
    [SerializeField] AudioSource audioSource1;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseGame();
            screen.SetActive(true);
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        audioSource1.Play();
        Time.timeScale = 1;
        screen.SetActive(false);

    }
    public void MainMenu()
    {
        audioSource1.Play();
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
