using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public AudioSource bonk;

    void Start()
    {

    }

    public void ResetGame()
    {
        bonk.Play();
    }
}
