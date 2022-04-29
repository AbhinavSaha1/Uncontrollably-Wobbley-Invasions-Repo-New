using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardIdleState : GuardBaseState
{
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Hello from the Idle state");
        guard.GOguard.GetComponent<GuardReset>().ResetChildren();
        if(!guard.animator.enabled)
        {
            guard.animator.enabled = true;
        }
        guard.animator.SetBool("Running", false);
        guard.animator.SetBool("Push", false);
        guard.animator.SetBool("Grab", false);

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
