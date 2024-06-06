using System.Collections;
using UnityEngine;

public class jumpController : MonoBehaviour
{

    private bool isJumping = false;
    public PlayerController player;

    void Update()
    {
        if (!isJumping && Input.GetButtonDown("Jump"))
        {
            player.Jump();
            isJumping = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isJumping && (other.CompareTag("Ground") || other.CompareTag("ice")))
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isJumping && ((other.CompareTag("Ground") || other.CompareTag("ice"))))
        {
            isJumping = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.CompareTag("Ground") || other.CompareTag("ice")))
        {
            isJumping = true;
        }
    }
   
}
