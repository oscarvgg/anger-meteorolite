using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerUp : MonoBehaviour {

	public Button back;
	public Text tshield;
	public Text tinvincible;
	public Text tweight;
	public Button bshield;
	public Button binvincible;
	public Button bweight;
	public Text textCoins;
	public int coins;
	int priceShield=1000000;
	int priceInvincible=1000000;
	int priceWeight=1000000;
	public int levelSh;
	public int levelIn;
	public int levelWe;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("Coins") != null) {
			coins = GameObject.Find ("Coins").GetComponent<Coins> ().coins;
			textCoins.text = ""+coins +" coins";
		} else {
			textCoins.text = "0"+" coins";
		}

		PowerUpsMeteor pu = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
		Debug.Log (pu.lvInv);
		levelIn = pu.lvInv;

		levelSh = pu.lvShield;
		levelWe = pu.lvWeight;
		tshield.text="Lv." + pu.lvShield;
		tinvincible.text="Lv." + pu.lvInv;
		tweight.text="Lv." + pu.lvWeight;

		
	}
	
	// Update is called once per frame
	void Update () {
		tshield.text = "Lv." + levelSh;
		tinvincible.text = "Lv." + levelIn;
		tweight.text = "Lv." + levelWe;
		priceShield=1000000*(levelSh+1);
		priceInvincible=1000000*(levelIn+1);
		priceWeight=1000000*(levelWe+1);

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
			if (GameObject.Find ("PowerUpsPlayer") != null) {
				PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
				pum.lvInv = levelIn;
			}
		}
	}

	public void Weight(){
		Debug.Log ("Hola We");
		if (coins >= priceWeight) {
			coins = coins - priceWeight;
			levelWe++;
			if (GameObject.Find ("PowerUpsPlayer") != null) {
				PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
				pum.lvWeight = levelWe;
			}
		}
	}

	public void Shield(){
		Debug.Log ("Hola Sh");
		if (coins >= priceShield) {
			Debug.Log (priceShield);
			coins = coins - priceShield;
			levelSh++;
			if (GameObject.Find ("PowerUpsPlayer") != null) {
				PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
				pum.lvShield = levelSh;
			}
		}
	}

	public void GoBack(){
		back.GetComponent<Image> ().color = Color.grey;
		SceneManager.LoadScene ("MAINPAGE");
	}
}

