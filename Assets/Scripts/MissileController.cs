using UnityEngine;
using System.Collections;

public class MissileController : MonoBehaviour {

	public GameObject gameControllerGameObject;
	public GameObject target;
	public bool shouldFollowTarget = true;
	public float speed = 1;
	public float distanceToStop = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var distance = Vector3.Distance(this.target.transform.position, this.transform.position);
		System.Console.WriteLine("distance: " + distance);
		if (distance < this.distanceToStop || this.transform.position.z < 0) {
			this.shouldFollowTarget = false;
		}
		else {
			this.shouldFollowTarget = true;
		}
			
		if (this.transform.position.z < 0) {
			this.gameObject.SetActive(false);
			var gameController = gameControllerGameObject.GetComponent<GameController>();
			gameController.actualNumberOfMissilesOnScreen--;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
			if (other.gameObject.tag == "CleanUp") {
				this.gameObject.SetActive(false);
			}
	}
}
