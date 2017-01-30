using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MENU1 : MonoBehaviour

{
	public Button backB;
	public Toggle bgm;
	public Toggle far;
	public Toggle medium;
	public Toggle close;

	void Start(){
	}

	public void GoBack(){
		backB.GetComponent<Image> ().color = Color.grey;
		SceneManager.LoadScene ("MAINPAGE");
	}

	public void BGM(bool newvalue){
		AudioSource asour=GameObject.Find("Main Camera").GetComponent<AudioSource> ();
		if (bgm.isOn) {
			asour.mute = false;
			GameObject.Find ("Settings").GetComponent<SettingGame> ().mute = false;
		} else {
			asour.mute = true;
			GameObject.Find ("Settings").GetComponent<SettingGame> ().mute = true;
		}
	}

	public void Far(bool newvalue){
		far.interactable = false;
		medium.interactable = true;
		close.interactable = true;
		GameObject.Find ("Settings").GetComponent<SettingGame> ().camera = -0.5f;
	}

	public void Medium(bool newvalue){
		far.interactable = true;
		medium.interactable = false;
		close.interactable = true;
		GameObject.Find ("Settings").GetComponent<SettingGame> ().camera = 0;
	}

	public void Close(bool newvalue){
		far.interactable = true;
		medium.interactable = true;
		close.interactable = false;
		GameObject.Find ("Settings").GetComponent<SettingGame> ().camera = +0.5f;
	}




}

