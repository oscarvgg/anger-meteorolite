using UnityEngine;
using System.Collections;

public class CenterBehabiour : MonoBehaviour {

	private Vector3 initialPosition;

	// Use this for initialization
	void Start () {
		this.initialPosition = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		var controller = this.gameObject.GetComponent(typeof(PlayerController)) as PlayerController;
		if (!controller.isUnderPlayerControl) {
			transform.localPosition = Vector3.MoveTowards(
			transform.localPosition, 
			this.initialPosition, // new Vector3(0, -0.1f, 1.4f), 
			controller.horizontalSpeed * Time.deltaTime);
		}
	}
}
