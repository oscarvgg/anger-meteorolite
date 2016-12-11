using UnityEngine;
using System.Collections;

public class LunchMissileBehaviour : MonoBehaviour {

	public Transform groundPosition;
	public float minTime = 2.0f;
	public float maxTime = 5.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine(this.launchAfterSomeTime());
	}
	
	// Update is called once per frame
	void Update () {
	}


	IEnumerator launchAfterSomeTime() {
		var timeToLaunch = Random.Range(this.minTime, this.maxTime);
		yield return new WaitForSeconds(timeToLaunch);
		this.lunchMissile();
	}


	void lunchMissile() {
		var controller = this.gameObject.GetComponent<GameController>();

		if (controller.actualNumberOfMissilesOnScreen > controller.maxNumberOfMissilesOnScreen) {
			StartCoroutine(this.launchAfterSomeTime());
			return;
		}

		var pool = this.gameObject.GetComponent<ObjectPoolScript>();
		var missile = pool.GetPooledObject();
		if (missile == null) {
			StartCoroutine(this.launchAfterSomeTime());
			return;
		}

		var spawnPosition = new Vector3(Random.Range(-11, 11), Random.Range(-7, 7), groundPosition.position.z - 2);
		missile.transform.position = spawnPosition;
		//		missile.transform.rotation = Quaternion.identity);
		missile.SetActive(true);
		controller.actualNumberOfMissilesOnScreen++;
		if (!controller.hasGameEnded) {
			StartCoroutine(this.launchAfterSomeTime());
		}
	}
}
