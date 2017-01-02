using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public Transform canvas;
	public Transform player;






	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}
	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false)
		{
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			player.GetComponent<FirstPersonController>().enabled = false;
		}
		else
		{
			canvas.gameObject.SetActive(false);
			Time.timeScale = 1;
			player.GetComponent<FirstPersonController>().enabled = true;
		}
	}

	public void Menu(){
		SceneManager.LoadScene("MAINPAGE");
	}

	public void Resume(){
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
		player.GetComponent<FirstPersonController>().enabled = true;
	}
}

