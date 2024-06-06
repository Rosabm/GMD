using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IceController : MonoBehaviour
{
    Rigidbody rb;
    private bool floating = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (floating)
        {
           rb.AddForce(new Vector3(0f, 5.3f, 0f));
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("liquid"))
        {
            floating = true;
           
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("liquid"))
        {
            floating = false;
        }

    }
}
