﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoBackMenu: MonoBehaviour
{
	public void back(){
		SceneManager.LoadScene ("MAINPAGE");
	}
}
