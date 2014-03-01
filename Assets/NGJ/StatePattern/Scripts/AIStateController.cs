using UnityEngine;
using System.Collections;

public class AIStateController : MonoBehaviour {

	private StateManager stateManager;


    void Start()
    {
		stateManager = GetComponent<StateManager>();
		stateManager.EnterTheFirstState(new LossingState());
    }

    void Update()
    {
<<<<<<< HEAD:Assets/NGJ/StatePattern/Scripts/AIStateController.cs
=======
		if (Input.GetKeyDown(KeyCode.Space)){
			stateManager.SwitchState(new LossingState());
		}
>>>>>>> b9582692cc233990a7b49bbe27249116215abaaa:Assets/NGJ/StatePattern/Scripts/StateGameController.cs

    }
}
