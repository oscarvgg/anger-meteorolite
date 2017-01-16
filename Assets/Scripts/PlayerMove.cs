using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float distance = 5;
	public float speed=3;
	public GameObject meteor;

	private Vector3 initialPosition;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		this.initialPosition = this.transform.localPosition;
	}

	void Update(){
		float limitXB = meteor.transform.position.x - 2.5f;
		float limitXA = meteor.transform.position.x + 2.5f;
		bool used = false;
		if (Input.GetMouseButton (0)) {
			float valueX = meteor.transform.position.x + Input.GetAxis ("Mouse X") * speed * Time.deltaTime;
			float valueZ = meteor.transform.position.z + Input.GetAxis ("Mouse Y") * speed * Time.deltaTime;
			used = true;
				
			transform.position = new Vector3 (valueX, meteor.transform.position.y, valueZ);
		} 
		if(used==false){
			transform.localPosition = Vector3.MoveTowards(
				transform.localPosition, 
				this.initialPosition, // new Vector3(0, -0.1f, 1.4f), 
				speed * Time.deltaTime);
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
	}


	IEnumerator Seconds(){
		yield return new WaitForSeconds (5f);
		speed = 3f;
	}
}
