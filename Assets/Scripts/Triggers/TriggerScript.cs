using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider player)
    {
        playSound.Play();
    }
}
