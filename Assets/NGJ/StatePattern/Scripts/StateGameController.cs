using UnityEngine;
using System.Collections;

public class StateGameController : MonoBehaviour {

	private StateManager stateManager;

    void Start()
    {
		stateManager = GetComponent<StateManager>();
		stateManager.EnterTheFirstState(new PlayingState());
    }

    void Update()
    {
    }
}
