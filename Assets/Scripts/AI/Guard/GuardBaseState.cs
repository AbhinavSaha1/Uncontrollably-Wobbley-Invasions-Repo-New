using UnityEngine;

public abstract class GuardBaseState
{
    public abstract void EnterState(GuardStateManager guard);
    
    public abstract void UpdateState(GuardStateManager guard);
    
    public abstract void OnTriggerEnter(GuardStateManager guard, Collider other);
}
