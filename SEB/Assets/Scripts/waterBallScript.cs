using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            other.gameObject.SetActive(false);
            pointCounter.PointCount++;
        }
        if (other.tag == "plantEnemy")
        {
            Destroy(gameObject);
            other.gameObject.gameObject.transform.localScale += new Vector3(1, 1, 1);
        }
    }
}