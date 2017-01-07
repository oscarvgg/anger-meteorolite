using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDK : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		this.gameObject.SetActive (false);
	}


}
