using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FootballerStateManager : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Animator animator;
    //public float chaseRadius;
    public float punchRadius;
    public float changeStateDelay;
    public PitchGuardActivator pitchGuardActivator;
    public Transform playerTarget;
    public Transform[] wavePoints;

    public FootballerBaseState currentState;
    public FootballerBaseState IdleState = new FootballerIdleState();
    public FootballerBaseState WaitingState = new FootballerWaitState();
    public FootballerBaseState PanicState = new FootballerPanicState();
    public FootballerBaseState ChaseState = new FootballerChaseState();
    public FootballerBaseState AttackState = new FootballerAttackState();

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
        Debug.Log("Trigger entered");
        currentState.OnTriggerEnter(this, other);
    }
    private void OnTriggerExit(Collider other)
    {
        currentState.OnTriggerExit(this, other);
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
