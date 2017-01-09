using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour {
	public Toggle bgm;

	// Use this for initialization
	void Start () {
		if(GameObject.Find("Settings")!=null){
			bool act = GameObject.Find ("Settings").GetComponent<SettingGame> ().mute;
			GetComponent<AudioSource> ().mute = act;
			if (bgm != null) {
				bgm.isOn = !act;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
