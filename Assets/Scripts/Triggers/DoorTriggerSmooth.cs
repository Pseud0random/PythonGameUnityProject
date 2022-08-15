using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerSmooth : MonoBehaviour
{
    [SerializeField] GameObject door;
    bool isOpen = false;
    [SerializeField] float max = 10f;
    [SerializeField] float rate = 0.1f; 
    float height = 0;
    private void OnTriggerEnter(Collider other)
    {
        
        if (!isOpen)
        {
            do
            {
                door.transform.position += new Vector3(0, rate, 0);
                height += rate;
            }
            while (height < max);

            isOpen = true;
        }

    }
}
