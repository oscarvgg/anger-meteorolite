using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float distance = 5;
	public float speed=0.00000001f;
	public GameObject meteor;

	private Vector3 initialPosition;
	private Touch touch;
	private float posZup=0;
	private float posZdown=0;
	private float posXRight=0;
	private float posXLeft=0;
	Vector3 rotation;

	private Vector3 pos;
	bool falling=true;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		this.initialPosition = this.transform.localPosition;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		rotation = new Vector3 (Time.deltaTime * 10, Time.deltaTime * 10, Time.deltaTime * 10);
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

		if (GameObject.Find ("Settings") != null) {
			float dis = GameObject.Find ("Settings").GetComponent<SettingGame> ().camera;
			transform.position = new Vector3 (pos.x, pos.y -1.5f + dis, pos.z+0.1f);
		}
		if(posZup==0 && posZdown==0 && posXLeft==0 && posXRight==0){
			transform.Rotate(rotation);
		}
		if (meteor.transform.position.z <= 46) {
			this.transform.Translate (0, 0, posZup);
		}
		if (meteor.transform.position.z >= 43.8) {
			this.transform.Translate (0, 0, posZdown);
		}

		if (meteor.transform.position.x <= 1.8) {
			this.transform.Translate (posXRight, 0,0 );
		}
		if (meteor.transform.position.x >= -1.8) {
			this.transform.Translate (posXLeft, 0,0 );
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
			speed = 0.00000000001f;
			StartCoroutine (Seconds ());
		}
		if (other.gameObject.tag == "Ground") {
			falling = false;
		}
	}


	IEnumerator Seconds(){
		yield return new WaitForSeconds (5f);
		speed = 0.00000001f;
	}

	public void GoUp(){
		rotation = Vector3.zero;
		if (meteor.transform.position.z <= 46) {
			
			posZup = 1.5f*Time.deltaTime;
		}
	}

	public void GoDown(){
		rotation = Vector3.zero;
		if (meteor.transform.position.z >= 43.8) {
			
			posZdown = -1.5f*Time.deltaTime;
		}
	}

	public void GoRight(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x <= 1.8) {
			
			posXRight = 1.5f*Time.deltaTime;
		}
	}

	public void GoLeft(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x >= -1.8) {

			posXLeft = -1.5f*Time.deltaTime;
		}
	}

	public void GoLeftDown(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x >= -1.8) {

			posXLeft = -1.5f*Time.deltaTime;
		}

		if (meteor.transform.position.z >= 43.8) {

			posZdown = -1.5f*Time.deltaTime;
		}
	}

	public void GoLeftUp(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x >= -1.8) {

			posXLeft = -1.5f*Time.deltaTime;
		}

		if (meteor.transform.position.z <= 46) {

			posZup = 1.5f*Time.deltaTime;
		}
	}

	public void GoRightDown(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x <= 1.8) {

			posXRight = 1.5f*Time.deltaTime;
		}

		if (meteor.transform.position.z >= 43.5) {

			posZdown = -1.5f*Time.deltaTime;
		}
	}

	public void GoRightUp(){
		rotation = Vector3.zero;
		if (meteor.transform.position.x <= 1.8) {

			posXRight = 1.5f*Time.deltaTime;
		}

		if (meteor.transform.position.z <= 46) {

			posZup = 1.5f*Time.deltaTime;
		}
	}





	public void Anything(){
		//rotation = new Vector3 (0, 0, Time.deltaTime * 10);
		posZup = 0;
		posZdown = 0;
		posXRight=0;
		posXLeft=0;
		rotation = new Vector3 (Time.deltaTime * 10, Time.deltaTime * 10, Time.deltaTime * 10);


	}
}
