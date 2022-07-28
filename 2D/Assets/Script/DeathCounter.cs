using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int dEATH =  0;
    public GameObject ATM;
    public AudioSource audioSource;

    public void IncreaseDeathCount()
    {
        dEATH++;
        countText.text = "Debts paid: " + dEATH;
        if (dEATH == 9)
        {
            audioSource.Play();
            ATM.gameObject.SetActive(true);
        }
    }
}
