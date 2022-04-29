using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerIdleState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer in Idle state");
        footballer.footballerReset.ResetChildren();
        footballer.navAgent.enabled = true;
        footballer.navAgent.isStopped = true;
        //footballer.animator.SetBool("Idle")
        //stop nav mesh
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //check condition for going into the next state
        if (footballer.pitchGuardActivator.isInActivationZone)
        {
            if (footballer.testStun)
            {
                footballer.SwitchState(footballer.StunState);
            }
            else
                footballer.SwitchState(footballer.WaitingState);
            //footballer.navAgent.isStopped = false;
        }
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {

    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
       
    }

}
