using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsEarn : MonoBehaviour {

	public Text win;
	// Use this for initialization
	void Start () {
		Coins coins = GameObject.Find ("Coins").GetComponent<Coins> ();
		win.text = "You have earned " + coins.actCoins + " coins";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
