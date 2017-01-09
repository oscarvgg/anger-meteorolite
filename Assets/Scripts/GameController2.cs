using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour {

	public bool hasGameEnded = false;
	public int maxNumberOfMissilesOnScreen = 3;
	public int actualNumberOfMissilesOnScreen = 0;
	public GameObject cube;
	public GameObject coinsText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (this.hasGameEnded) {
			float valor=GameObject.Find ("Meteor").GetComponent<Weight> ().ValActual;
			cube.SetActive (true);
			GameObject.Find ("Destruction").GetComponent<Expansion> ().speed = valor;
			coinsText.SetActive (true);
			StartCoroutine (Explosion());
		}
	}

	IEnumerator Explosion(){
		yield return new WaitForSeconds(6f);
		SceneManager.LoadScene ("GAME OVER2");
	}
}
