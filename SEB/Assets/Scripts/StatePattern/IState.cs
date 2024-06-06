using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{

    public void Enter()
    {
        // code that runs when we first enter the state
    }

    public void Update()
    {
    }

    public void Exit()
    {
        // code that runs when we exit the state
    }

    public void FireBall() {
        // code that runs when we fireABall
    }

    public void OnTriggerEnter(Collider other);

    public void OnCollisionStay(Collision collision);
}