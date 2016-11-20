using UnityEngine;
using System.Collections;

public class CenterBehabiour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var controller = this.gameObject.GetComponent(typeof(PlayerController)) as PlayerController;
		if (!controller.isUnderPlayerControl) {
			transform.position = Vector3.MoveTowards(
			transform.position, 
			new Vector3(0, 0, 0), 
			controller.horizontalSpeed * Time.deltaTime);
		}
	}
}
