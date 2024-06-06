using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class AirState : StateMachineBehaviour, IState
{

        public PlayerController player;
        private AudioSource source;
        private float startTime;


        // pass in any parameters you need in the constructors
        public AirState(PlayerController player)
        {
            this.player = player;
            source= player.gameObject.GetComponent<AudioSource>();
        }


        public void Enter()
        {
         player.airBoy.SetActive(true);
        startTime = Time.time;
        HealthManager.hasItem = false;

    }


        // per-frame logic, include condition to transition to a new state
        public void Update()
        {
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0f)
        {
            player.anim.SetBool("flying", true);
            player.transform.Translate(vertical * Vector3.up * 10f * Time.deltaTime);
           
        }
        else
        {
            player.anim.SetBool("flying", false);
        }
        if(Time.time>startTime+10)
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.waterState);
        }
           
    }


    public void Exit()
        {
          player.airBoy.SetActive(false);
        player.anim.SetBool("flying", false);
    }

        public void FireBall()
        {
        GameObject ball = Instantiate(player.airBallPrefab, new Vector3(player.transform.position.x + 0.3f, player.transform.position.y + 0.5f, player.transform.position.z), player.transform.rotation);
        var ballRb = ball.GetComponent<Rigidbody>();
        ballRb.AddForce(player.transform.forward * 500f);
        Destroy(ball, 2f);
        }

         public void OnTriggerEnter(Collider other)
         {
      
        if (other.CompareTag("airCollect"))
        {
            source.PlayOneShot(player.coinSound, 1f);
            pointCounter.PointCount++;
            Destroy(other.gameObject);
        }
 }
        public void OnCollisionStay(Collision collision)
        { }
        
}
