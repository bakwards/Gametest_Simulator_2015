using UnityEngine;
using System.Collections;

public class AllanController : MonoBehaviour {

	public float walkSpeed = 0.1f;
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 newDirection = Vector3.Normalize(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
		rigidbody.MovePosition(transform.position + newDirection * walkSpeed);
		transform.LookAt(transform.position + newDirection);
	}
	void OnMouseDown() {
		Debug.Log ("hey");
		}
}
