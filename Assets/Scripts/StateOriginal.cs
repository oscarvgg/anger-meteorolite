using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateOriginal : MonoBehaviour {

	public static StateOriginal stateOriginal;
	public Button b;

	void Awake(){
		if (stateOriginal == null) {
			stateOriginal = this;
			DontDestroyOnLoad (gameObject);
		} else if (stateOriginal != this) {
			Destroy (gameObject);
		}
	}


}
