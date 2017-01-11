using UnityEngine;
using System.Collections;

public class MoveForwardBehaviour1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var controller = this.GetComponent(typeof(MissileController)) as MissileController;
		if (!controller.shouldFollowTarget) {
			var zMovement = this.transform.position.z - (controller.speed * Time.deltaTime);
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, zMovement);
		}
	}
}
