using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerWaitState : FootballerBaseState
{
    public override void EnterState(FootballerStateManager footballer)
    {
        Debug.Log("Footballer entered waiting state");
        footballer.StartCoroutine(StateDelayRoutuine(footballer));
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
    
    IEnumerator StateDelayRoutuine(FootballerStateManager footballer)
    {
        yield return new WaitForSeconds(footballer.changeStateDelay);
        footballer.SwitchState(footballer.PanicState);
    }

}
