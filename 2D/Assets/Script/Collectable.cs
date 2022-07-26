using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectable : MonoBehaviour
{

    GameObject myTextgameObject;
    public  Text cCount;
    public bool isCollected;

    void Start()
    {
        isCollected = false;
     
    }

    void Update()
    {
        if (isCollected)
        {
            isCollected = false;
                    
            Destroy(gameObject);

            
        }
        
    }
}
