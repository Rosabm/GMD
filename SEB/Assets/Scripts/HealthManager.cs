using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public GameObject item;
    public static int health;
    public static bool hasItem;
    void Start()
    {
        health = 3;
        item.SetActive(false);
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
        hasItem = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;
            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            default:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
        }
        if(hasItem)
        {
            item.SetActive(true);
        }
        else
        {
            item.SetActive(false);
        }
    }
}
