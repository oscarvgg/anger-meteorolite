using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour {

	public GameObject team, polimi, polimigame;
	// Use this for initialization
	void Start () {
		team.SetActive (false);
		polimi.SetActive (true);
		polimigame.SetActive (false);
		StartCoroutine (Polimi());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Polimi(){
		yield return new WaitForSeconds(3f);
		polimi.SetActive (false);
		polimigame.SetActive (true);
		StartCoroutine (PolimiGame());
	}

	IEnumerator PolimiGame(){
		yield return new WaitForSeconds(3f);
		polimigame.SetActive (false);
		team.SetActive (true);
		StartCoroutine (Team());
	}

	IEnumerator Team(){
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene ("MAINPAGE");
	}
}
