using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FootballerStateManager : MonoBehaviour
{
    public NavMeshAgent navAgent;
    //public float chaseRadius;
    public float punchRadius;
    public float changeStateDelay;
    public PitchGuardActivator pitchGuardActivator;
    public Transform[] wavePoints;

    public FootballerBaseState currentState;
    public FootballerBaseState IdleState = new FootballerIdleState();
    public FootballerBaseState WaitingState = new FootballerWaitState();
    public FootballerBaseState PanicState = new FootballerPanicState();
    public FootballerBaseState ChaseState = new FootballerChaseState();

    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }
    public void SwitchState(FootballerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(
            center: this.transform.position,
            radius: this.punchRadius
        ) ;
    }
}
