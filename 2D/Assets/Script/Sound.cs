using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sound : MonoBehaviour
{
    public new AudioSource audio;
    //public TextMeshPro score;
    //public int count = PlayerPrefs.GetInt("count");
    //Start is called before the first frame update
    void Start()
    {
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = count.ToString();
    }
}
