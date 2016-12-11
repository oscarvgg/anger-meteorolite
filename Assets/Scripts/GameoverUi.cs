using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverUi : MonoBehaviour {
    public string gamelevel1 = "MAINPAGE";

	// Use this for initialization
	public void Gameover () {
        {
            // Application.LoadLevel(gameLevel1);
            SceneManager.LoadScene(gamelevel1);
        }
    }
	
}
