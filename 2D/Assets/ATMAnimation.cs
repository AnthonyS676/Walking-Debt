using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        audioSource.Play();
        anim.Play("Enter");
    }
}
