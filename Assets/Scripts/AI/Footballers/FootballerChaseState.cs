using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerChaseState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered chase state");
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //set navmesh to the player
        //check if in punch radius
        //if in punch radius: Either changes state to attack state or attack through here
    }
}
