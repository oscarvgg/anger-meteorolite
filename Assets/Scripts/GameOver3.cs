using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver3 : MonoBehaviour {

	public Text rt;
	public Text mt;
	public void Restart(){
		rt.color = Color.grey;
		SceneManager.LoadScene ("PlayerController3");
	}


	public void Menu(){
		mt.color = Color.grey;
		SceneManager.LoadScene ("MAINPAGE");
	}
}
