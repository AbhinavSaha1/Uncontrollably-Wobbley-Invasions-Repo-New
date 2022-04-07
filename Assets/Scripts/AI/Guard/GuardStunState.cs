using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
        for (int a = 0; a < guard.bodyParts.Length; a++)
        {
            guard.bodyParts[a].isKinematic = false;
        }

        yield return new WaitForSeconds(5);
        //Break player grab
        GameObject.FindObjectOfType<Item>().Release();
        yield return new WaitForSeconds(1);
        //guard.GetComponent<Rigidbody>().AddRelativeForce(guard.transform.forward * -5000);
        
       //yield return new WaitForSeconds(0.45f);

        for (int a = 0; a < guard.bodyParts.Length; a++)
        {
            guard.bodyParts[a].isKinematic = true;
        }

        //yield return new WaitForSeconds(2);

        guard.SwitchState(guard.IdleState);
    }

}
