using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public StateMachine PlayerStateMachine;
    public GameObject fireBoy;
    public GameObject airBoy;
    public GameObject waterBoy;
    Rigidbody rb;
    public bool isJumping = false;
    public Vector3 startPosition;
    public Vector3 respawnPosition;
    public Animator anim;
    public static bool moving=false;
    private bool lookingRight;
    public GameObject fireBallPrefab;
    public GameObject airBallPrefab;
    public GameObject waterBallPrefab;
    public AudioClip jumpSound;
    public AudioClip fireBallSound;
    public AudioClip savePointSound;
    public AudioClip coinSound;
    private AudioSource source;
    public AudioClip dyingSound;
    public bool hasAirItem;
 

    private void Awake()
    {
        // initialize state machine
        PlayerStateMachine = new StateMachine(this);
        source= GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerStateMachine.Initialize(PlayerStateMachine.fireState);
        startPosition = transform.position;
        respawnPosition= SceneManager.GetActiveScene().name == "tutorial" ? new Vector3(-7, 1, 0): transform.position;
        rb = GetComponent<Rigidbody>();
        waterBoy.SetActive(false);
        airBoy.SetActive(false);
        anim = GetComponent<Animator>();
        lookingRight= true;
        hasAirItem= false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0f)
        {
            transform.Translate(horizontal * (lookingRight? Vector3.forward:Vector3.back) * 5f * Time.deltaTime);
            if(horizontal<0 && lookingRight)
            {
                transform.Rotate(new Vector3(0, 180, 0));
                lookingRight= false;
            }
            if (horizontal > 0 && !lookingRight)
            {
                transform.Rotate(new Vector3(0, 180, 0));
                lookingRight = true;
            }
            moving = true;
        }
        else
        {
            moving = false;
        }
   

        if (Input.GetButtonDown("Fire1"))
        {
            source.PlayOneShot(fireBallSound, 1f);
            anim.SetTrigger("fireBall");
            PlayerStateMachine.FireBall();
  
        }
         anim.SetBool("moving", moving);
         PlayerStateMachine.Update();
    }



    private void OnTriggerEnter(Collider other)
    {
        PlayerStateMachine.OnTrigger(other);
        if (other.CompareTag("savePoint"))
        {
            source.PlayOneShot(savePointSound, 1f);
            respawnPosition = transform.position;
        }
        if (other.CompareTag("airItem"))
        {
            other.gameObject.SetActive(false);
            hasAirItem = true;
            HealthManager.hasItem = true ;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        PlayerStateMachine.OnCollisionStay(collision);
    }


    public void Jump()
    {
        source.PlayOneShot(jumpSound, 1f);
        rb.AddForce(new Vector3(0, 1, 0) * 200f);
    }
}

