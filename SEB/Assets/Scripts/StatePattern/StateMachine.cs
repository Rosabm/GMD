using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // handles
    [Serializable]
    public class StateMachine
    {
        public IState CurrentState { get; private set; }

        // reference to the state objects
        public FireState fireState;
        public WaterState waterState;
        public AirState airState;

    // event to notify other objects of the state change
    public event Action<IState> stateChanged;

        // pass in necessary parameters into constructor 
        public StateMachine(PlayerController player)
        {
            // create an instance for each state and pass in PlayerController
            this.fireState = new FireState(player);
            this.waterState = new WaterState(player);
            this.airState = new AirState(player);
    }

        // set the starting state
        public void Initialize(IState state)
        {
            CurrentState = state;
            state.Enter();

            // notify other objects that state has changed
            stateChanged?.Invoke(state);
        }

        // exit this state and enter another
        public void TransitionTo(IState nextState)
        {
            CurrentState.Exit();
            CurrentState = nextState;
            nextState.Enter();

            // notify other objects that state has changed
            stateChanged?.Invoke(nextState);
        }

        // allow the StateMachine to update this state
        public void Update()
        {
            if (CurrentState != null)
            {
                CurrentState.Update();
            }
        }

    public void FireBall()
    {
        if (CurrentState != null) { CurrentState.FireBall(); }
    }

    public void OnTrigger(Collider other)
    { if (other != null) { if (CurrentState != null) { CurrentState.OnTriggerEnter(other); } } }
   

        public void OnCollisionStay(Collision collision)
        { 
             if (CurrentState != null) { CurrentState.OnCollisionStay(collision); } 
        }


 }