using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }

    void LateUpdate()
    {
        if (SceneManager.GetActiveScene().name=="tutorial" ? (player.transform.position.x >= -7.69f && player.transform.position.x<= 75): player.transform.position.x >= -4.80f)
        { 
        transform.position = new Vector3(player.transform.position.x,transform.position.y, transform.position.z) + offset;
        }
    }
}
