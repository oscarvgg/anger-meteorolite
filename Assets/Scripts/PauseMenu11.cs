using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu11 : MonoBehaviour {
    public GameObject pauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    public Text mutetext;
    public AudioSource audio;

    // Use this for initialization
    void Start () {
        paused = false;
        pauseMenu = GameObject.Find("pauseMenu");
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

        }

        if(paused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if(!paused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if(muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "UnMute";
        }
        else if(!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
		
	}
    public void Resume()
    {
        paused = false;
    }
    public void MainMenu()
    {
         SceneManager.LoadScene("MAINPAGE");
        //Application.LoadLevel("Menu");
    }

    public void Save()
    {
        //you can save weapons, points, stages and many other things, i am saving scene here
        //PlayerPrefs.SetInt("Menu", SceneManager.sceneLoaded);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Load()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
}
    public void Mute()
    {
        
        audio = GetComponent<AudioSource>();
      //if (Input.GetKeyDown(KeyCode.Space))
            if (audio.mute)
                audio.mute = false;
            else
                audio.mute = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
