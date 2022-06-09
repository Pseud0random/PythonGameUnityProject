using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//to be assigned to all individual buttons

public class ButtonCol : MonoBehaviour
{
    public void OnTriggerEnter(Collider Player)
    {
        //turn the public variable from parent into a local one
        GameObject ButtonGame = GameObject.Find("ButtonGame");
        ButtonGameScript buttonGameScript = ButtonGame.GetComponent<ButtonGameScript>();

        //if correct button flash green, else red
        if (buttonGameScript.correct == true)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
        }
        else
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;
        }

        //variable to tell ButtonGameScript when its been pressed
        bool pressed = true;

    }
}
