using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

	public static Coins script;
	public long coins;
	public long actCoins;

	void Awake(){
		if (script == null) {
			script = this;
			DontDestroyOnLoad (gameObject);
		} else if (script != this) {

			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		if(GameObject.Find("Buttons")!=null){
			GameObject.Find ("Buttons").GetComponent<PowerUp> ().coins = coins;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Destruction") != null) {
			actCoins = GameObject.Find ("Destruction").GetComponent<Expansion> ().game;
		}
	}
}
