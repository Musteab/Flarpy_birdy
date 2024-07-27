using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class soundeffectplayer : MonoBehaviour
{
   public AudioSource scoreSound;
    public AudioClip sfx;


    public void button1()
    {
        scoreSound.clip = sfx;
        scoreSound.Play();

    }


}
