using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//to be assigned only to "ButtonGame"

public class ButtonGameScript : MonoBehaviour
{
    public bool correct = false;

    //wont create Button1 as a local variable like in the other script for some reason...
    GameObject Button1 = GameObject.Find("Button1");
    ButtonCol buttonCol = Button1.GetComponent<ButtonCol>();



    private void OnTriggerEnter(Collider Player)
    {
        //buncha if statements to determine an order of button pressing,
        //sending true and false "correct" statements to the buttons to flash in response.
        //should reset if a false is sent.
    }

}
