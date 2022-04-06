using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerAttackState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered Attack state");
        //if puncher {Punch()}
        //if grabber {Grab()}
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        if (Vector3.Distance(footballer.playerTarget.position, footballer.transform.position) > footballer.punchRadius)
        {
            Debug.Log("Changing state from Chase -> Attack");
            footballer.SwitchState(footballer.ChaseState);
        }
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        
    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
        
    }

}
