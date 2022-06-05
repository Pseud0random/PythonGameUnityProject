using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSFX : MonoBehaviour
{
   public AudioSource playSound;
   public AudioSource pauseSound;
   private bool istriggered = false;

    private void OnTriggerEnter(Collider Player)
    {
        if (istriggered == false)
        {
            playSound.Play();
            pauseSound.Stop();
            istriggered = true;
        }
    }
}
