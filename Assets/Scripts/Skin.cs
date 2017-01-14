using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour {
	public static Skin type;
	public Texture skin;

	void Awake(){
		if (type == null) {
			type = this;
			DontDestroyOnLoad (gameObject);
		} else if (type != this) {
			Destroy (gameObject);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
