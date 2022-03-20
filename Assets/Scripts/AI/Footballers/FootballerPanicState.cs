using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerPanicState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered panic state");
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        //Chase the player: Call chase state
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //move nav mest to panic waypoints
    }
}
