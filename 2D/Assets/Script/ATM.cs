using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ATM : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public int score;
    
    // Start is called before the first frame update
    void Awake()
    {
        countText.text = "" + score;
        Crystal.score = score;
    }
    void Start()
    {
        Crystal.score = score;
        countText.text = "" + score;
    }

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
        DontDestroyOnLoad(countText.gameObject);
        DontDestroyOnLoad(this.gameObject);
            SceneManager.LoadScene("YouWin");

       
    }
}
