using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerIdleState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer in Idle state");
        //stop nav mesh
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //check condition for going into the next state
    }
}
