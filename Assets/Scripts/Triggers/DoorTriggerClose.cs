using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerClose : MonoBehaviour
{
    [SerializeField] GameObject door;
    bool isOpen = true;
    private void OnTriggerEnter(Collider other)
    {
        if (isOpen)
        {
            door.transform.position -= new Vector3(0, 5, 0);
            isOpen = false;
        }

    }
}
