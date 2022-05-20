using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource bonk;

    // Start is called before the first frame update
    void Start()
    {
        bonk.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playBonk()
    {
        bonk.Play();
    }
}
