using UnityEngine;

public class StateManager : MonoBehaviour
{    
    private State _activeState;
    public State ActiveState
    {
        get
        {
            return _activeState;
        }
    }

    void Update()
    {
        if (_activeState != null)
        {
            _activeState.StateUpdate();
        }
    }

    public void SwitchState(State newState)
    {
        _activeState.ExitState();
        _activeState = newState;
        _activeState.EnterState();
    }

    public void EnterTheFirstState(State firstState)
    {
        _activeState = firstState;
        _activeState.EnterState();
    }

    void Init()
    {

    }
}