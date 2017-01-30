using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsMeteor : MonoBehaviour {

	public int lvShield=0;
	public int lvInv=0;
	public int lvWeight=0;

	public static PowerUpsMeteor script;

	void Awake(){
		if (script == null) {
			script = this;
			DontDestroyOnLoad (gameObject);
		} else if (script != this) {

			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Start () {
		if (GameObject.Find ("Buttons") != null) {
			PowerUp pu = GameObject.Find ("Buttons").GetComponent<PowerUp> ();
			pu.levelIn = lvInv;
			pu.levelSh = lvShield;
			pu.levelWe = lvWeight;
			pu.tshield.text="Lv." + lvShield;
			pu.tinvincible.text="Lv." + lvInv;
			pu.tweight.text="Lv." + lvWeight;
		}
		if (GameObject.Find ("GameController")!=null) {
			PauseMenu pum = GameObject.Find ("GameController").GetComponent<PauseMenu> ();
			if (lvInv <= 0) {
				pum.inv.gameObject.SetActive (false);
			}
			if (lvWeight <= 0) {
				pum.weight.gameObject.SetActive (false);
			}
			if (lvShield <= 0) {
				pum.shield.gameObject.SetActive (false);
			}
		}
	}
}
