using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

	void Update(){
		transform.position = transform.position - transform.up;
	}
	
	void OnTriggerEnter ( Collider other ){
		Debug.Log("Bump!");
	}
}
