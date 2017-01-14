using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{
	public void Play(){
		SceneManager.LoadScene ("Planets");
	}

	public void PowerUp(){
		SceneManager.LoadScene ("Power Up");
	}

	public void Setting(){
		SceneManager.LoadScene ("Setting");
	}

	public void ChangeSkin(){
		SceneManager.LoadScene ("Change skin");
	}
}
