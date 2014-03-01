using UnityEngine;
using System.Collections;

//requires tag on agents: ReviewAgent

public class AllanCalls : MonoBehaviour {

	public float maxDistance = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			AllanCall();
		}
	}

	void AllanCall(){
		float minDistance = maxDistance;
		GameObject callObject = null;
		foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("ReviewAgent")){
			float distanceToObject = Vector3.Distance(this.transform.position, fooObj.transform.position);
			if(distanceToObject < maxDistance){
				if(callObject == null || distanceToObject < minDistance){
					minDistance = distanceToObject;
					callObject = fooObj;
				}
			}
		}
		if(callObject != null){
			if(callObject.GetComponent<NavAgentControl>().Follow()){
				callObject.GetComponent<NavAgentControl>().SetTarget(this.gameObject);
			}
		}
	}
}
