using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IdleState", menuName = "Uncontrollably Wobbley Invasions/States/Idle", order = 1)]
public class IdleState : AbstractFSMStates
{
    public override bool EnterState()
    {
        base.EnterState();
        Debug.Log("Entered Ideal state");
        EnteredState = true;
        return EnteredState;
    }

    public override void UpdateState()
    {
        Debug.Log("Updating Ideal state");
    }
    public override bool ExitState()
    {
        base.ExitState();
        Debug.Log("Exiting Ideal state");
        return true;
    }
}
