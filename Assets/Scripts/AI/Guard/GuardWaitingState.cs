using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardWaitingState : GuardBaseState
{
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Entering Waiting State");
        guard.StartCoroutine(StateDelayRoutuine(guard));
    }

    public override void OnTriggerEnter(GuardStateManager guard, Collider other)
    {

    }

    public override void UpdateState(GuardStateManager guard)
    {
        if (!guard.pitchGuardActivator.isInActivationZone)
        {
            guard.SwitchState(guard.IdleState);
        }
    }
    IEnumerator StateDelayRoutuine(GuardStateManager guard)
    {
        yield return new WaitForSeconds(guard.changeStateDelay);
        guard.SwitchState(guard.ChaseState);
        guard.isWaiting = false;
    }
}
