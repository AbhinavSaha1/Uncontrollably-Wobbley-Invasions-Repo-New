using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardArrestState : GuardBaseState
{
    Transform selectedWaypoint;
    float maxBreakForce = 8000;
    float breakForce;
    Transform currentWaypoint;
    Vector3 distance;
    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Arresting the player");
        //breakForce = guard.playerHips.GetComponent<FixedJoint>().breakForce;
        if (guard.canGrab)
        {
            
        }
        PlayerGrab(guard);
        
        int index = Random.Range(0, guard.guardArrestWaypoints.Length);
        selectedWaypoint = guard.guardArrestWaypoints[index];

        /* selectedWaypoint =
         for(int i= 0; i <guard.guardArrestWaypoints.Length; i++)
         {
             currentWaypoint = guard.guardArrestWaypoints[i];
             if(Vector3.Distance(currentWaypoint.position, guard.transform.position) < )
             {

             }
         }*/

    }

    public override void UpdateState(GuardStateManager guard)
    {
        if(selectedWaypoint != null)
        {
            guard.navAgent.SetDestination(selectedWaypoint.position);
            if (Vector3.Distance(selectedWaypoint.position, guard.transform.position) < guard.waypointThrowActivationRadius)
            {
                guard.DestroyCall(guard.playerHips.GetComponent<FixedJoint>());
                guard.AddForceCall(guard.playerHips);
                guard.SwitchState(guard.IdleState);
            }
        }
        if (guard.jointBreakCheck.hasJointBroken && !guard.isWaiting)
        {
            guard.jointBreakCheck.hasJointBroken = false;
            guard.isWaiting = true;
            //PUT THE GUARD IN THE STUN STATE HERE
            guard.SwitchState(guard.StunState);

            //guard.StartCoroutine(SwitchStateDelay(guard));
        }
        
        /*if (Vector3.Distance(guard.target.position, guard.transform.position) > guard.activationRadius && !guard.isWaiting)
        {
            guard.isWaiting = true;
            guard.SwitchState(guard.IdleState);

            //guard.StartCoroutine(SwitchStateDelay(guard));
        }*/
    }

    public override void OnTriggerEnter(GuardStateManager guard, Collider other)
    {
        
    }
    void PlayerGrab(GuardStateManager guard)
    {
        guard.canGrab = false;
        guard.playerHips.AddComponent<FixedJoint>();
        guard.playerHips.GetComponent<FixedJoint>().connectedBody = guard.gameObject.transform.parent.GetComponent<Rigidbody>();
        guard.playerHips.GetComponent<FixedJoint>().breakForce = 4000;
        guard.StartCoroutine(BreakforceIncreaseRoutine(guard));
        BreakForceReduce(guard);
    }
    IEnumerator BreakforceIncreaseRoutine(GuardStateManager guard)
    {
        while (guard.playerHips.GetComponent<FixedJoint>().breakForce <= maxBreakForce)
        {
            Debug.Log("Entered breakforceincreas routine");
            yield return new WaitForSeconds(5);

            if (guard.playerHips.GetComponent<FixedJoint>() != null)
            {
                guard.playerHips.GetComponent<FixedJoint>().breakForce += 50;
            }
        }

    }
    void BreakForceReduce(GuardStateManager guard)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Breakforce reduced");
            guard.playerHips.GetComponent<FixedJoint>().breakForce -= 50;
        }
    }
            
}
