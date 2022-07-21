using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject door;
    bool isOpen = false;
    private void OnTriggerEnter(Collider other)
    {
        if(!isOpen)
        {
            door.transform.position += new Vector3(0, 5, 0);
            isOpen = true;
        }
        
    }
}
