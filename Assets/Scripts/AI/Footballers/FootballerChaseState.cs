using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerChaseState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered chase state");
    }

    public override void UpdateState(FootballerStateManager footballer)
    {
        //set navmesh to the player
        footballer.navAgent.SetDestination(footballer.playerTarget.position);
        if (Vector3.Distance(footballer.playerTarget.position, footballer.transform.position) < footballer.punchRadius)
        {
            Debug.Log("Changing state from Chase -> Attack");

            if(GameObject.FindObjectOfType<PlayerHealth>().playerStunned)
            {
                footballer.SwitchState(footballer.IdleState);
            }
            else 
            footballer.SwitchState(footballer.AttackState);
        }
    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
       
    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
        if (other.CompareTag("Player"))
        {
            footballer.SwitchState(footballer.IdleState);
        }
    }
}
