using UnityEngine;
using System.Collections;

public class FollowBehaviour : MonoBehaviour {

	public GameObject target;
	public int turn = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var controller = this.GetComponent(typeof(MissileController)) as MissileController;
		if (controller.shouldFollowTarget) {
		// 	transform.position = Vector3.MoveTowards(
		// 		transform.position, 
		// 		target.transform.position, 
		// 		controller.speed * Time.deltaTime);
			var targetRotation = Quaternion.LookRotation(target.transform.position - this.transform.position);
			this.GetComponent<Rigidbody>().MoveRotation(Quaternion.RotateTowards(this.transform.rotation, targetRotation, this.turn));
		}
		else {
			System.Console.WriteLine("stop follow");
		}
	}
}
