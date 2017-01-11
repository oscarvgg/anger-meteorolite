using UnityEngine;
using System.Collections;

public class MissileController1 : MonoBehaviour {

	public GameObject gameControllerGameObject;
	public GameObject target;
	public bool shouldFollowTarget = true;
	public float speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var distance = Vector3.Distance(this.target.transform.position, this.transform.position);
		if (distance < 2 || this.transform.position.z < 0) {
			this.shouldFollowTarget = false;
		}
		else {
			this.shouldFollowTarget = true;
		}
			
		if (this.transform.position.z < -3) {
			this.gameObject.SetActive(false);
			var gameController = gameControllerGameObject.GetComponent<GameController>();
			gameController.actualNumberOfMissilesOnScreen--;
		}
	}
}
