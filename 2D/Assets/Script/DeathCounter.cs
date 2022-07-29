using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int dEATH = 0;
    public GameObject ATM;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public void IncreaseDeathCount()
    {
        audioSource2.Play();
        dEATH = dEATH + 1;
        countText.text = "Debts paid: " + dEATH;
        Debug.Log("add");
        if (dEATH == 9)
        {
            audioSource.Play();
            ATM.gameObject.SetActive(true);
            gameObject.SetActive(false);
            Invoke("Win", 3f);
            //Debug.Log("de");
        }
    }
   
}
