﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateOrange : MonoBehaviour {

	public static StateOrange stateOrange;

	void Awake(){
		if (stateOrange == null) {
			stateOrange = this;
			DontDestroyOnLoad (gameObject);
		} else if (stateOrange != this) {
			Destroy (gameObject);
		}
	}
}
