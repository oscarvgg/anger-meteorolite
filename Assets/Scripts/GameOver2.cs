using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour {

	public void Restart(){
		SceneManager.LoadScene ("PlayerController2");
	}


	public void Menu(){
		SceneManager.LoadScene ("MAINPAGE");
	}
}
