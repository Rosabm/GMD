using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dyingController : MonoBehaviour
{
    public GameObject[] thingsToRestore;
    public GameObject ice1, ice2, ice3;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void die()
    {
        player.hasAirItem= false;
        spiderSpawnCounter.count = 0;
        foreach (GameObject go in thingsToRestore) {
            if(!go.activeInHierarchy) { 
            go.SetActive(true);}
        }
        ice1.transform.position = new Vector3(43.314888f, 1.79f, -0.159999996f);
        ice2.transform.position = new Vector3(71.8700027f,2.41f, -0.109999999f);
        ice3.transform.position = new Vector3(202.220001f, 3.85f, -0.170000002f);
        ice1.transform.localScale = new Vector3(1.25f, 0.75f, 2.0157001f);
        ice2.transform.localScale = new Vector3(2, 2, 2.70027685f);
        ice3.transform.localScale = new Vector3(1.25f, 0.75f, 1.86749995f);
    }
}
