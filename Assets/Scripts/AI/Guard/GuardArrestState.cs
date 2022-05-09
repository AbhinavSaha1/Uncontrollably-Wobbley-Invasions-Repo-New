using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardArrestState : GuardBaseState
{
    Transform selectedWaypoint;
    float maxBreakForce = 8000;
    FixedJoint _fixedJoint;
    Transform currentWaypoint;
    Vector3 distance;
    BreakForceBar breakForceBar;

    public override void EnterState(GuardStateManager guard)
    {
        Debug.Log("Arresting the player");
        guard.animator.SetBool("Grab", true);
        breakForceBar = GameObject.FindObjectOfType<BreakForceBar>();

        _fixedJoint = guard.playerHips.GetComponent<FixedJoint>();
        if (guard.canGrab)
        {
            
        }
        PlayerGrab(guard);
        
        /*int index = Random.Range(0, guard.guardArrestWaypoints.Length);
        selectedWaypoint = guard.guardArrestWaypoints[index];*/

        float minDist = float.MaxValue;
        //selectedWaypoint =
         for(int i= 0; i <guard.guardArrestWaypoints.Length; i++)
         {
             
             currentWaypoint = guard.guardArrestWaypoints[i];
             float dist = Vector3.Distance(currentWaypoint.position, guard.transform.position);

             if (dist < minDist)
             {
                selectedWaypoint = currentWaypoint;
                minDist = dist;
             }
         }

    }

    public override void UpdateState(GuardStateManager guard)
    {
        if(selectedWaypoint != null)
        {
            guard.navAgent.SetDestination(selectedWaypoint.position);
            if(Vector3.Distance(selectedWaypoint.position, guard.transform.position) < 3)
            {
                guard.animator.SetBool("Push", true);
            }
            if (Vector3.Distance(selectedWaypoint.position, guard.transform.position) < guard.waypointThrowActivationRadius)
            {
                guard.DestroyCall(guard.playerHips.GetComponent<FixedJoint>());
                guard.AddForceCall(guard.playerHips);
                guard.playerArrested = false;
                guard.animator.SetBool("Grab", false);
                guard.SwitchState(guard.IdleState);
            }
        }
        if (guard.jointBreakCheck.hasJointBroken && !guard.isWaiting)
        {
            guard.jointBreakCheck.hasJointBroken = false;
            guard.isWaiting = true;
            guard.playerArrested = false;
            //PUT THE GUARD IN THE STUN STATE HERE
            guard.SwitchState(guard.StunState);

            //guard.StartCoroutine(SwitchStateDelay(guard));
        }
        BreakForceReduce(guard);

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
        guard.playerArrested = true;
        for (int i = 0; i < guard.footballers.Length; i++)
        {
            guard.footballers[i].SwitchState(guard.footballers[i].PanicState);
        }
        guard.canGrab = false;
        _fixedJoint= guard.playerHips.AddComponent<FixedJoint>();
        _fixedJoint.connectedBody = guard.gameObject.transform.parent.GetComponent<Rigidbody>();
        _fixedJoint.breakForce = guard.jointBreakForce;
        guard.StartCoroutine(BreakforceIncreaseRoutine(guard));
        breakForceBar.SetInitialForce();
    }
    IEnumerator BreakforceIncreaseRoutine(GuardStateManager guard)
    {
        while ((_fixedJoint!= null) && _fixedJoint.breakForce <= maxBreakForce)
        {
            Debug.Log("Entered breakforceincreas routine");
            _fixedJoint.breakForce += 50;
            breakForceBar.CurrentVal -= 1;
            breakForceBar.SetForce(breakForceBar.CurrentVal);
            yield return new WaitForSeconds(5);
        }

    }
    
    void BreakForceReduce(GuardStateManager guard)
    {
        if(Input.GetKeyDown(KeyCode.Z) && !GameObject.FindObjectOfType<PlayerHealth>().playerStunned)
        {
            Debug.Log("Breakforce reduced");
            _fixedJoint.breakForce -= 50;
            breakForceBar.CurrentVal += 1;
            breakForceBar.SetForce(breakForceBar.CurrentVal);
        }
    }
            
}
