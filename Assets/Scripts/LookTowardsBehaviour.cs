using UnityEngine;
using System.Collections;

public class LookTowardsBehaviour : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.LookAt(target.transform.position, Vector3.up);
	}
}
