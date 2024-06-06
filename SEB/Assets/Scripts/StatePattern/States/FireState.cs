using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



    public class FireState : StateMachineBehaviour, IState
{

        private PlayerController player;
        private AudioSource source;

    // pass in any parameters you need in the constructors
    public FireState(PlayerController player)
        {
            this.player = player;
            source = player.gameObject.GetComponent<AudioSource>();
    }


    public void Enter()
        {
          player.fireBoy.SetActive(true);
        }


        // per-frame logic, include condition to transition to a new state
        public void Update()
        {
        float useItem = Input.GetAxis("useItem");
        if (UnityEngine.Input.GetButtonDown("Change power"))
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.waterState);
        }
        if (useItem!=0 && player.hasAirItem==true)
        {
            player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.airState);
        }
    }


        public void Exit()
        {
        player.fireBoy.SetActive(false);
        }

        public void FireBall()
        {
        GameObject ball = Instantiate(player.fireBallPrefab, new Vector3(player.transform.position.x + 0.3f, player.transform.position.y + 0.5f, player.transform.position.z), player.transform.rotation);
        var ballRb = ball.GetComponent<Rigidbody>();
        ballRb.AddForce(player.transform.forward * 500f);
        Destroy(ball, 2f);
        }

       public void OnTriggerEnter(Collider other)
        {
        
        if (other.CompareTag("fireCollect"))
        {
            source.PlayOneShot(player.coinSound, 1f);
            pointCounter.PointCount++;
            Destroy(other.gameObject);
        }
    }

        public void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.CompareTag("ice") && collision.gameObject.transform.localScale.y>0 && collision.gameObject.transform.localScale.x > 0)
            {
            collision.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0)*Time.deltaTime;
        }
        }
    
}
