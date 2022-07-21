using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WARNING: SCRIPT IN DEBUGGING

public class buttonGameScript : MonoBehaviour
{
    public string[] order = new string[4] {"Button2", "Button3" , "Button1" , "Button4" };
    public bool win = false;
    //pont system, if the user gets 4 then they have pressed all buttons in order and have won
    public int count = 0;
    string lastButton;

    // Update is called once per frame
    void Update()
    {
        /*correct button is pressed*/
        if (CheckButton(count) == true)
        {
            //they get one more 'point'
            count++;

            //debug line
            print($"Count = {count}");
        }

        if (count == 4)
        {
            //if they press all buttons in order they win
            win = true;

            //debug line
            print($"Win = {win}");
        }
    }

    public bool CheckButton(int count)
    {
            bool correct = false;
        //check if the correct button has been pressed
        if(lastButton == order[count])
        {
            correct = true;

            //debug line
            print($"Correct = {correct}");
        }

            return correct;
    }
    //retrive the update from the button that has been pressed, output string that represents that button
    public void CheckPress(string buttonNo)
    {
        //assign to a local variable because idk how else to handle this =/
        lastButton = buttonNo;
        //debug line
        print($"LastButton = {lastButton}");
    }
}
