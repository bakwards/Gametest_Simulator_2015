using UnityEngine;
using System.Collections;

public class NavAgentControl : MonoBehaviour {

	public GameObject targetPoint;
	
	public float reviewSize = 1000;
	public float reviewProgress = 0;
	
	public float peeThreshold = 150;
	public float peeNeed = 0;
	
	public bool isPeeing = false;
	
	public bool isSmoker = true;

	public bool isWorking = false;

	public bool isDone = false;
	
	public float smokingTreshold = 100;
	public float smokingNeed = 0;
	
	public bool isSmoking = false;

	private NavMeshAgent agent;
	
	public GameObject peeArea;
	public GameObject smokingArea;
	public GameObject workArea;
	public GameObject kontoret;

	public bool follow = false; //new stuff

	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent>();
		agent.SetDestination(workArea.transform.position);
		targetPoint = workArea;
	}
	
	void Update () {
<<<<<<< HEAD
		CheckDestination();
		if(isPeeing ){
=======
		if(follow){ //new stuff
			agent.SetDestination(targetPoint.transform.position);
		}
		if(!isPeeing && peeNeed < peeThreshold){
			peeNeed += Time.deltaTime;
			if(peeNeed >= peeThreshold){
				follow = false; // new - temp?
				isWorking = false;
				SetTarget(peeArea);
			}
		}
		if(!isSmoking && isSmoker && smokingNeed < smokingTreshold){
			smokingNeed += Time.deltaTime;
			if(smokingNeed >= smokingTreshold){
				follow = false; // new - temp?
				isWorking = false;
				SetTarget(smokingArea);
			}
		}
		if(isPeeing){
>>>>>>> b9582692cc233990a7b49bbe27249116215abaaa
			peeNeed -= Time.deltaTime * 16;
			if(peeNeed < 0){
				isPeeing = false;
				peeNeed = 0;
				if(smokingNeed < smokingTreshold){
					SetTarget(workArea);
				} else {
					SetTarget(smokingArea);
				}
			}
		}
		if(isSmoking){
			smokingNeed -= Time.deltaTime * 10;
			if(smokingNeed < 0){
				isSmoking = false;
				smokingNeed = 0;
				if(peeNeed < peeThreshold){
					SetTarget(workArea);
				} else {
					SetTarget(peeArea);
				}
			}
		}
		if (isWorking){
			reviewProgress += Time.deltaTime;
		}
		if (reviewProgress >= reviewSize && isWorking) {
			isWorking = false;
			SetTarget(kontoret);
			workArea = kontoret;
		}
	}

	void FixedUpdate () {		
		agent.SetDestination(targetPoint.transform.position);
	}

	private void CheckDestination(){
		if(!isPeeing && peeNeed < peeThreshold){
			peeNeed += Time.deltaTime;
		}
		if(peeNeed >= peeThreshold){
			follow = false; // new - temp?
			SetTarget(peeArea);
		}
		if(!isSmoking && isSmoker && smokingNeed < smokingTreshold){
			smokingNeed += Time.deltaTime;
		}
		if(smokingNeed >= smokingTreshold){
			follow = false; // new - temp?
			SetTarget(smokingArea);
		}
	}
	
	public void SetTarget ( GameObject newTarget ) {
		targetPoint = newTarget;
		agent.SetDestination(targetPoint.transform.position);
	}

	public bool Follow(){ // new function
		follow = !follow;
		if(!follow){
			SetTarget(workArea);
		}
		return follow;
	}
	
	void OnTriggerEnter ( Collider other ){
		Debug.Log("Trigger entered by " + gameObject.name);
<<<<<<< HEAD
		if(other.gameObject.tag == "SmokingArea" && !follow){
			isSmoking = true;
		} else if (other.gameObject.tag == "PeeArea" && !follow){
			isPeeing = true;
		} else if (other.gameObject.tag == "WorkArea" && !follow){
			
=======
		if (other.gameObject.tag == "SmokingArea") {
				isSmoking = true;
		} else if (other.gameObject.tag == "PeeArea") {
				isPeeing = true;
		} else if (other.gameObject.tag == "WorkArea") {
				isWorking = true;
		} else if (other.gameObject.tag == "Kontoret") {
				isDone = true;
>>>>>>> b9582692cc233990a7b49bbe27249116215abaaa
		}
	}
}
