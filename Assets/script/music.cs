using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class music : MonoBehaviour
{
    public Slider backMusic;
    public AudioSource audio;

   
   void Update()
    {
        audio.volume = backMusic.value;

    }
}
