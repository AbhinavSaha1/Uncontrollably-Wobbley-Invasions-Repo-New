using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardStateManager : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Transform target;
    public float activationRadius = 5;
    public float waypointThrowActivationRadius = 1;
    public float changeStateDelay;
    public float guardArrestToChaseStageDelay;
    public bool canGrab;
    public bool isWaiting;
    public Transform[] guardArrestWaypoints;
    public PitchGuardActivator pitchGuardActivator;
    public JointBreakCheck jointBreakCheck;

    public GameObject playerHips;

    public GuardBaseState currentState;
    public GuardBaseState IdleState = new GuardIdleState();
    public GuardBaseState WaitingState = new GuardWaitingState();
    public GuardBaseState ChaseState = new GuardChaseState();
    public GuardBaseState ArrestState = new GuardArrestState();
    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this);
        jointBreakCheck = GameObject.FindObjectOfType<JointBreakCheck>();
    }

    
    void Update()
    {
        currentState.UpdateState(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }

    public void SwitchState(GuardBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
    public void DestroyCall(Component component)
    {
        Destroy(component);
    }
    public void AddForceCall(GameObject gameObject)
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(transform.forward*50000);
        Debug.Log("Added explosion force");
    }
 
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(
            center: this.transform.position,
            radius: this.activationRadius
        );
    }
}
