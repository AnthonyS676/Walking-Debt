using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI countText;


    // Start is called before the first frame update
    void Start()
    {
        countText.text = Crystal.score.ToString();
    }

}
