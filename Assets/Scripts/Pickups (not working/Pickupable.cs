using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{

    Rigidbody rb;
    public int boxID;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetPickedUpState(Transform holder)
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        transform.parent = holder;
    }

    public void SetDroppedState()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        transform.parent = null;
    }

    public int ReturnBoxID()
    {
        return boxID;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
