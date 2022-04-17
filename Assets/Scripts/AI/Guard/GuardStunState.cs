using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardStunState : GuardBaseState
{
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Entered Stun state");
        guard.StartCoroutine(StunRoutine(guard));
        
    }

    public override void UpdateState(GuardStateManager guard)
    {

    }

    public override void OnTriggerEnter(GuardStateManager guard, Collider other)
    {
        
    }
    IEnumerator StunRoutine(GuardStateManager guard)
    {
        guard.navAgent.enabled = false;
        GuardHealth guardHealth = GameObject.FindObjectOfType<GuardHealth>();
        guardHealth.canDamage = false;

        for (int a = 0; a < guard.bodyParts.Length; a++)
        {
            guard.bodyParts[a].isKinematic = false;
        }

        yield return new WaitForSeconds(5);
        //Break player grab
        GameObject.FindObjectOfType<Item>().Release();
        yield return new WaitForSeconds(1);

        for (int a = 0; a < guard.bodyParts.Length; a++)
        {
            guard.bodyParts[a].isKinematic = true;
        }
        guardHealth.canDamage = true;

        //yield return new WaitForSeconds(1);

        // PlaceGuardOnNavmesh(guard);

        /*if(!guard.navAgent.isOnNavMesh)
        {
            Debug.Log("Placing the guard on navmesh");
            var position = guard.guardPos.position;
            NavMesh.SamplePosition(position, out NavMeshHit navhit, 10.0f, 1);
            position = navhit.position; // usually this barely changes, if at all
            guard.navAgent.Warp(position);
        }*/
        guard.SwitchState(guard.IdleState);
    }

    private void PlaceGuardOnNavmesh(GuardStateManager guard)
    {
        Debug.Log("Placing the guard on navmesh");
        var position = guard.guardPos.position;
        NavMesh.SamplePosition(position, out NavMeshHit navhit, 10.0f, 1);
        position = navhit.position; // usually this barely changes, if at all
        guard.navAgent.Warp(position);
    }
}
