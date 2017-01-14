using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingGame : MonoBehaviour {
	public static SettingGame game;
	public bool mute;
	public float camera;

	void Awake(){
		if (game == null) {
			game = this;
			DontDestroyOnLoad (gameObject);
		} else if (game != this) {
			
			Destroy (gameObject);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
