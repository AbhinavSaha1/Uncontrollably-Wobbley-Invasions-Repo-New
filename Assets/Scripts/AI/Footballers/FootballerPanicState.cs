using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerPanicState : FootballerBaseState
{
    Transform selectedWayPoint;
    float previousWayPointIndex;
    GameObject player;
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered panic state");
        //footballer.animator.SetBool("Punch", false);
        
        footballer.navAgent.isStopped = false;
      
        
       
        int index = Random.Range(0, footballer.wavePoints.Length);
        previousWayPointIndex = index;
        selectedWayPoint = footballer.wavePoints[index];
    }
    
    public override void UpdateState(FootballerStateManager footballer)
    {
        //move nav mest to panic waypoints
        if(selectedWayPoint != null)
        {
            footballer.navAgent.SetDestination(selectedWayPoint.position);

            if(Vector3.Distance(footballer.transform.position, selectedWayPoint.position) < 1)
            {
                selectedWayPoint = null;
            }
        }
        else if(selectedWayPoint == null)
        {
            int index = Random.Range(0, footballer.wavePoints.Length);
           
            if(previousWayPointIndex != index)
            {
                previousWayPointIndex = index;
                selectedWayPoint = footballer.wavePoints[index];
                Debug.Log("Setting a new waypoint");
            }
        }
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        //Chase the player: Call chase state

        Debug.Log(other.gameObject.name);
        if(other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Changing from Panic to Switch state");
            footballer.SwitchState(footballer.ChaseState);
        }
    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
        
    }
}
