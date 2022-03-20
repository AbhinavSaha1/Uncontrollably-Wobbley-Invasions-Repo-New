using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    [SerializeField]
    private AbstractFSMStates _startingState;
    
    private AbstractFSMStates _currentState;

    private void Awake()
    {
        _currentState = null;
    }
    public void Start()
    {
        if(_startingState!= null)
        {
            EnterState(_startingState);
        }
    }
    private void Update()
    {
        if(_currentState != null)
        {
            _currentState.UpdateState();
        }
    }

    #region STATE MANAGEMENT
    private void EnterState(AbstractFSMStates nextState)
    {
        if (nextState == null)
            return;

        _currentState = nextState;
        _currentState.EnterState();
    }
    #endregion

}
