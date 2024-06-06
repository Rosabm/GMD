using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class batController : MonoBehaviour
{

    public bool automaticMoving;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (automaticMoving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }

}
