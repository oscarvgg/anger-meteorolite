using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsMeteor : MonoBehaviour {

	public long lvShield=0;
	public long lvInv=0;
	public long lvWeight=0;


	// Update is called once per frame
	void Start () {
		if (GameObject.Find ("Buttons") != null) {
			PowerUp pu = GameObject.Find ("Buttons").GetComponent<PowerUp> ();
			pu.levelIn = lvInv;
			pu.levelSh = lvShield;
			pu.levelWe = lvWeight;
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
		DontDestroyOnLoad (gameObject);
	}
}
