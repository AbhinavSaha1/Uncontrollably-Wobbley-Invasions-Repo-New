using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Chase", menuName = "Uncontrollably Wobbley Invasions/States/Chase", order = 2)]
public class ChaseState : AbstractFSMStates
{
    [SerializeField] private NavMeshAgent _navMeshAgent;


    public override void OnEnable()
    {
        base.OnEnable();
    }
    public override bool EnterState()
    {
        if(base.EnterState())
        {
            //assign target
        }
        return base.EnterState();
    }
    public override void UpdateState()
    {
       if(EnteredState)
        {

        }
    }
}
