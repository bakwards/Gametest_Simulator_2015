using UnityEngine;
using System.Collections;

public class PlayingState : State
{
    public override string StateName
    {
        get
        {
            return this.GetType().ToString();
        }
    }

    public override void EnterState()
    {
		Debug.Log("IT works!");
    }

    public override void StateUpdate()
    {
    }
    public override void ExitState()
    {

    }
}
