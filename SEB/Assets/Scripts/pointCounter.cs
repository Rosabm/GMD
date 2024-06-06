using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointCounter : MonoBehaviour
{
    public static int PointCount = 0;
   
    public TextMeshProUGUI pointCountText;

    void Update()
    {
        if (PointCount>=20 && HealthManager.health<3)
        {
            HealthManager.health++;
            PointCount -= 20;
        }
        if (pointCountText != null)
        {
           pointCountText.text = "Points: "+ PointCount;
        }
    }




}
