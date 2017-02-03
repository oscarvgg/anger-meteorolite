using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour {

	public GameObject team, polimi;
	// Use this for initialization
	void Start () {
		team.SetActive (true);
		polimi.SetActive (false);
		StartCoroutine (Team());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Team(){
		yield return new WaitForSeconds(3f);
		team.SetActive (false);
		polimi.SetActive (true);
		StartCoroutine (Polimi());
	}

	IEnumerator Polimi(){
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene ("MAINPAGE");
	}
}
