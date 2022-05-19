using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hippo : MonoBehaviour
{
    public bool hasLanded = false;
    public Animator mAnimator;
    public AudioSource boing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!this.hasLanded)
        {
            boing.Play();
            this.hasLanded = true;
            mAnimator.SetTrigger("TrIdle");
        }
    }
}
