﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject gameControllerObject;
	public GameObject explosion;
	public GameObject camera;
	public GameObject respawn;
	public GameObject meteor;
	public GameObject mete0;
	/// Speed in which the player moves vertically and horizontally
	public float horizontalSpeed = 1f;
	public float fallSpeed = .5f;

	/// Determines whether the user is tapping/clicking to move the object 
	public bool isUnderPlayerControl = false;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("MeteorInitial") != null){
			meteor.GetComponent<Renderer> ().sharedMaterial = GameObject.Find ("MeteorInitial").GetComponent<Renderer> ().material;
			mete0.GetComponent<Renderer> ().sharedMaterial = GameObject.Find ("MeteorInitial").GetComponent<Renderer> ().material;

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Ground")
		{
			Vector3 pos = camera.transform.position;
			var gameController = gameControllerObject.GetComponent<GameController>();
			gameController.hasGameEnded = true;
			explosion.gameObject.SetActive (true);
			meteor.GetComponent<Rigidbody> ().isKinematic = true;
			camera.GetComponent<Rigidbody> ().isKinematic = true;
			camera.GetComponent<Rigidbody> ().useGravity = false;
			camera.transform.position= new Vector3 (camera.transform.position.x, camera.transform.position.y+300f, camera.transform.position.z);
			meteor.transform.position= new Vector3 (meteor.transform.position.x, meteor.transform.position.y-300f, meteor.transform.position.z);


		}
		if(col.gameObject.tag == "Missile")
		{
			col.gameObject.SetActive(false);

		}
	}

}
