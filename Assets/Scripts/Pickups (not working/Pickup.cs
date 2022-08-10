using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* this is all code i copied from here: 
 * https://www.youtube.com/watch?v=ZGJOw0t23aY
 */

public class Pickup : MonoBehaviour
{

    public Transform holdPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 50.0f, Color.red);
        CheckForPickup();
    }

    private void CheckForPickup()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20.0f))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (hit.transform.gameObject.GetComponent<Pickupable>())
                {
                    //pickup box
                    hit.transform.gameObject.GetComponent<Pickupable>().SetPickedUpState(holdPosition);
                }
            }
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (hit.transform.GetComponent<Pickupable>())
            {
                //drop box
                hit.transform.gameObject.GetComponent<Pickupable>().SetDroppedState();
            }
        }
    }
}

/*
 *  
*/
