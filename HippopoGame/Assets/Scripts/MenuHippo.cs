using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHippo : MonoBehaviour
{
    public Animator mAnimator;
    public Hippo hippo;

    // Start is called before the first frame update
    void Start()
    {
        this.hippo.hasLanded = true;
        mAnimator.SetTrigger("TrIdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
