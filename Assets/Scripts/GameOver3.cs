using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver3 : MonoBehaviour {

	public void Restart(){
		SceneManager.LoadScene ("PlayerController3");
	}


	public void Menu(){
		SceneManager.LoadScene ("MAINPAGE");
	}
}
