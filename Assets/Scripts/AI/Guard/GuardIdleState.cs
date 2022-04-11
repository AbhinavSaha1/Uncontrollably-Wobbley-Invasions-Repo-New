using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardIdleState : GuardBaseState
{
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Hello from the Idle state");
        guard.GOguard.GetComponent<GuardReset>().ResetChildren();

        guard.navAgent.enabled = true;
        guard.navAgent.isStopped = true;
    }

    public override void UpdateState(GuardStateManager guard)
    {
        //guard.SwitchState(guard.ChaseState);
        if(guard.pitchGuardActivator.isInActivationZone)
        {
            guard.SwitchState(guard.WaitingState);
        }
    }

    public override void OnTriggerEnter(GuardStateManager guard, Collider other)
    {

    }   
}
