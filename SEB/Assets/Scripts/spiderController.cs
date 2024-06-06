using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spiderController : MonoBehaviour
{
    public bool automaticMoving;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(automaticMoving) { 
        transform.Translate(Vector3.back* Time.deltaTime);
        }
    }

}
