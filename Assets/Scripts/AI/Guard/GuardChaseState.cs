using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardChaseState : GuardBaseState
{
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("You are now in chase state");
        guard.navAgent.isStopped = false;
        guard.canGrab = true;
    }

    public override void UpdateState(GuardStateManager guard)
    {
        if (!guard.pitchGuardActivator.isInActivationZone)
        {
            guard.SwitchState(guard.IdleState);
        }

        if (guard.target != null)
        {
            guard.navAgent.SetDestination(guard.target.position);
            if (Vector3.Distance(guard.target.position, guard.transform.position) < guard.activationRadius)
            {
                Debug.Log("Changing state from Chase -> Arrest");
                guard.SwitchState(guard.ArrestState);
            }
        }  
    }

    public override void OnTriggerEnter(GuardStateManager guard, Collider other)
    {

    }
}
