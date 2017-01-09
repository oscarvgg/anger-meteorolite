using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerUp : MonoBehaviour {

	public Text tshield;
	public Text tinvincible;
	public Text tweight;
	public Button bshield;
	public Button binvincible;
	public Button bweight;
	public long coins;
	long priceShield=1000000L;
	long priceInvincible=1000000L;
	long priceWeight=1000000L;
	public long levelSh =0;
	public long levelIn =0;
	public long levelWe =0;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("Coins") != null) {
			coins = GameObject.Find ("Coins").GetComponent<Coins> ().coins;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		tshield.text = "Lv." + levelSh;
		tinvincible.text = "Lv." + levelIn;
		tweight.text = "Lv." + levelWe;
		priceShield=1000000L*(levelSh+1);
		priceInvincible=1000000L*(levelIn+1);
		priceWeight=1000000L*(levelWe+1);
		if (GameObject.Find ("PowerUpsPlayer") != null) {
			PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
			pum.lvInv = levelIn;
			pum.lvShield = levelSh;
			pum.lvWeight = levelWe;
		}
		if (coins >= priceShield) {
			bshield.interactable = true;
		} else {
			bshield.interactable = false;
		}
		if (coins >= priceInvincible) {
			binvincible.interactable = true;
		} else {
			binvincible.interactable = false;
		}
		if (coins >= priceWeight) {
			bweight.interactable = true;
		} else {
			bweight.interactable = false;
		}

		if (GameObject.Find ("Coins") != null) {
			GameObject.Find ("Coins").GetComponent<Coins> ().coins=coins;
		}
	}

	public void Invincible(){
		Debug.Log ("Hola INv");
		if (coins >= priceInvincible) {
			coins = coins - priceInvincible;
			levelIn++;
		}
	}

	public void Weight(){
		Debug.Log ("Hola We");
		if (coins >= priceWeight) {
			coins = coins - priceWeight;
			levelWe++;
		}
	}

	public void Shield(){
		Debug.Log ("Hola Sh");
		if (coins >= priceShield) {
			Debug.Log (priceShield);
			coins = coins - priceShield;
			levelSh++;
		}
	}

	public void GoBack(){
		SceneManager.LoadScene ("MAINPAGE");
	}
}

