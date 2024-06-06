using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class WaterState : StateMachineBehaviour, IState
{

        public PlayerController player;
        private AudioSource source;
   


        // pass in any parameters you need in the constructors
        public WaterState(PlayerController player)
        {
            this.player = player;
            source= player.gameObject.GetComponent<AudioSource>();
        }


        public void Enter()
        {
         player.waterBoy.SetActive(true);
         }


        // per-frame logic, include condition to transition to a new state
        public void Update()
        {
        float useItem = Input.GetAxis("useItem");
        if (Input.GetButtonDown("Change power"))
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.fireState);
        }
        if (useItem!=0 && player.hasAirItem == true)
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.airState);
        }
    }


    public void Exit()
        {
          player.waterBoy.SetActive(false);
         }

        public void FireBall()
        {
        GameObject ball = Instantiate(player.waterBallPrefab, new Vector3(player.transform.position.x + 0.3f, player.transform.position.y + 0.5f, player.transform.position.z), player.transform.rotation);
        var ballRb = ball.GetComponent<Rigidbody>();
        ballRb.AddForce(player.transform.forward * 500f);
        Destroy(ball, 2f);
        }

         public void OnTriggerEnter(Collider other)
         {
      
        if (other.CompareTag("waterCollect"))
        {
            source.PlayOneShot(player.coinSound, 1f);
            pointCounter.PointCount++;
            Destroy(other.gameObject);
        }
 }
        public void OnCollisionStay(Collision collision)
        {
           
        }

   
}
