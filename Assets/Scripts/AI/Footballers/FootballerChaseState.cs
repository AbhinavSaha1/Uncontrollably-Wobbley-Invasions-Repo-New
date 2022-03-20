using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerChaseState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered chase state");
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //set navmesh to the player
        footballer.navAgent.SetDestination(footballer.playerTarget.position);
        //check if in punch radius
        //if in punch radius: Either changes state to attack state or attack through here
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        
    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
        if (other.CompareTag("Player"))
        {
            footballer.SwitchState(footballer.IdleState);
        }
    }
}