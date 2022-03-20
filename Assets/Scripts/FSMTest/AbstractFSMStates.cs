using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum ExecutionState
{
    NONE,
    ACTIVE,
    COMPLETED
};  

public abstract class AbstractFSMStates : ScriptableObject
{
    public ExecutionState ExecutionState { get; protected set; }
    public bool EnteredState { get; protected set; }
    protected NavMeshAgent _navAgent;
    protected AI _aI;

    public virtual void OnEnable()
    {
        ExecutionState = ExecutionState.NONE;
    }
    public virtual bool EnterState()
    {
        bool successNavMesh = true;
        bool successAI = true;
        ExecutionState = ExecutionState.ACTIVE;
        
        //does the nav agent and AI exist
        successNavMesh = (_navAgent != null);
        successAI = (_aI != null);
        
        return successNavMesh & successAI;
    }
    public abstract void UpdateState();
    
    public virtual bool ExitState()
    {
        ExecutionState = ExecutionState.COMPLETED;
        return true;
    }

    public virtual void SetNavAgent(NavMeshAgent navMeshAgent)
    {
        if(navMeshAgent != null)
        {
            _navAgent = navMeshAgent;
        }
    }
    public virtual void SetAI(AI aI)
    {
        if(aI!= null)
        {
            _aI = aI;
        }
    }
}
