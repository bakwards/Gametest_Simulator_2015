using UnityEngine;
using System.Collections;

public class StateGameController : MonoBehaviour {

	private StateManager stateManager;

    void Start()
    {
		stateManager = GetComponent<StateManager>();
		stateManager.EnterTheFirstState(new LossingState());
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space)){
			stateManager.SwitchState(new LossingState());
		}

    }
}
