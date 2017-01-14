using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expansion : MonoBehaviour {
	public float speed;
	public Text coinsText;
	float posX;
	float posY;
	float posZ;
	Coins coins;
	public int game=0;
	// Update is called once per frame
	void Update () {
		posX += 0.00005f*speed * Time.deltaTime;
		posZ += 0.00005f*speed * Time.deltaTime;
		this.transform.localScale+= new Vector3 (posX, 0, posZ);
	}

	void OnTriggerEnter(Collider other){
		coins=GameObject.Find ("Coins").GetComponent<Coins> ();
		if (other.tag == "Building1") {
			

			coins.coins += 1000;
			game += 1000;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "Building2") {


			coins.coins += 1500;
			game += 1500;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "Building3") {


			coins.coins += 2000;
			game += 2000;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "Building4") {


			coins.coins += 2500;
			game += 2500;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "BuildingNew1") {


			coins.coins += 2000;
			game += 2000;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "BuildingNew2") {


			coins.coins += 2500;
			game += 2500;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

		if (other.tag == "BuildingNew3") {


			coins.coins += 3000;
			game += 3000;
			coinsText.text = game.ToString ();
			other.gameObject.SetActive (false);
		}

	}

}
	
