using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerStunState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered Stun State");
        footballer.StartCoroutine(FootballerStunRoutine(footballer));
    }

    public override void UpdateState(FootballerStateManager footballer)
    {

    }

    public override void OnTriggerEnter(FootballerStateManager footballer, Collider other)
    {
        
    }

    public override void OnTriggerExit(FootballerStateManager footballer, Collider other)
    {
       
    }
    IEnumerator FootballerStunRoutine(FootballerStateManager footballer)
    {
        footballer.navAgent.enabled = false;
        footballer.animator.enabled = false;
        //FootballerHealth footballerHealth = GameObject.FindObjectOfType<FootballerHealth>();
        //footballer.footballerHealth.canDamage = false;
        footballer.health.canDamage = false;

        for (int a = 0; a < footballer.bodyParts.Length; a++)
        {
            footballer.bodyParts[a].isKinematic = false;
        }

        yield return new WaitForSeconds(5);
        //Break player grab
        GameObject.FindObjectOfType<Item>().Release();
        yield return new WaitForSeconds(1);

        for (int a = 0; a < footballer.bodyParts.Length; a++)
        {
            footballer.bodyParts[a].isKinematic = true;
        }
        //footballerHealth.canDamage = true;
        footballer.testStun = false;
        footballer.health.canDamage = true;
        footballer.animator.enabled = true;
        footballer.SwitchState(footballer.IdleState);
    }
   
}
