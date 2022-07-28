using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAnimation : MonoBehaviour
{
    [SerializeField] string throwAnimation;
    Animator anim;
    public GameObject arm;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
        anim.Play(throwAnimation);
        StartCoroutine(SetToFalse());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SetToFalse()
    {
        yield return new WaitForSeconds(seconds);
        arm.SetActive(false);
    }
}
