using UnityEngine;
using System.Collections;

public class FollowBehaviour1 : MonoBehaviour {

	public GameObject target;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var controller = this.GetComponent(typeof(MissileController)) as MissileController;
		if (controller.shouldFollowTarget) {
			transform.position = Vector3.MoveTowards(
				transform.position, 
				target.transform.position, 
				controller.speed * Time.deltaTime);
		}
	}
}
