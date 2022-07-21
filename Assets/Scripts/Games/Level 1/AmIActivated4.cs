using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WARNING: SCRIPT IN DEBUGGING
public class AmIActivated4 : MonoBehaviour
{
    //declare buttongamescript into here to later pass button number through
    private buttonGameScript buttonGameScript;

    private void Start()
    {
        buttonGameScript = GetComponent<buttonGameScript>();
    }
    //if the user has pressed this button it will send a signal to the main script to say it has been.
    private void OnTriggerEnter(Collider other)
    {
        //this is the only part that should need to change for each button
        buttonGameScript.CheckPress("Button4");

        //debug line
        print("Button4 pressed");
    }
}
