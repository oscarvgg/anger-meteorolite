﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{
	public void play(){
		SceneManager.LoadScene ("Planets");
	}

    public void changeskin()
    {
        SceneManager.LoadScene("Change skin");
    }

}
