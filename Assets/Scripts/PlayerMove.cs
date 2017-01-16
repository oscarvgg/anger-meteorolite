using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float distance = 5;
	public float speed=3;
	public GameObject meteor;

	private Vector3 initialPosition;
	private Vector3 pos;
	bool falling=true;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		this.initialPosition = this.transform.localPosition;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	void Update(){
		MoveUpdate ();

	}

	void MoveUpdate(){
		if (Application.platform == RuntimePlatform.IPhonePlayer&&falling==true) {
			pos=Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y,1));
		}else{
			if (falling == true) {
				pos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1.5f));
			}
		}
		transform.position = new Vector3 (pos.x, pos.y -1.5f, pos.z+0.1f);

		if (GameObject.Find ("Settings") != null) {
			float dis = GameObject.Find ("Settings").GetComponent<SettingGame> ().camera;
			transform.position = new Vector3 (pos.x, pos.y -1.5f + dis, pos.z+0.1f);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "CleanUp") {
			transform.localPosition = Vector3.MoveTowards(
				transform.localPosition, 
				this.initialPosition, // new Vector3(0, -0.1f, 1.4f), 
				speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "Light") {
			other.gameObject.SetActive (false);
			speed = 1f;
			StartCoroutine (Seconds ());
		}
		if (other.gameObject.tag == "Ground") {
			falling = false;
		}
	}


	IEnumerator Seconds(){
		yield return new WaitForSeconds (5f);
		speed = 3f;
	}
}
