using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FootballerBaseState
{
    public abstract void EnterState(FootballerStateManager footballer);

    public abstract void UpdateState(FootballerStateManager footballer);

    public abstract void OnTriggerEnter(FootballerStateManager footballer, Collider other);
    
    public abstract void OnTriggerExit(FootballerStateManager footballer, Collider other);
}
