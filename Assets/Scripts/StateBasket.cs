using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBasket : MonoBehaviour {

	public static StateBasket stateBasket;

	void Awake(){
		if (stateBasket == null) {
			stateBasket = this;
			DontDestroyOnLoad (gameObject);
		} else if (stateBasket != this) {
			Destroy (gameObject);
		}
	}
}
