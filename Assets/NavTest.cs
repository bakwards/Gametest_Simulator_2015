using UnityEngine;
using System.Collections;

public class NavTest : MonoBehaviour {
	
	public GameObject targetPoint;
	
	private NavMeshAgent agent;
	
	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent>();
		agent.SetDestination(targetPoint.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(targetPoint.transform.position);
	}
}
