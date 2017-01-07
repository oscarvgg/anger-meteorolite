using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandSphere : MonoBehaviour {

	float posX;
	float posY;
	float posZ;
	// Update is called once per frame
	void Update () {
		posX += 0.1f * Time.deltaTime;
		posY += 0.1f * Time.deltaTime;
		posZ += 0.1f * Time.deltaTime;
		this.transform.localScale= new Vector3 (posX, this.transform.localScale.y, posZ);
	}

	void OnCollisionEnter(Collision other){
		other.gameObject.SetActive (false);
	}

}
	
