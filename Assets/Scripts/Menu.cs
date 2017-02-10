using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu: MonoBehaviour
{
	public Text playT;
	public Text PUT;
	public Text ST;
	public Text CST;
	public void Play(){
		playT.color = Color.grey;
		SceneManager.LoadScene ("Planets");
	}

	public void PowerUp(){
		PUT.color = Color.grey;
		SceneManager.LoadScene ("Power Up");
	}

	public void Setting(){
		ST.color = Color.grey;
		SceneManager.LoadScene ("Setting");
	}

	public void ChangeSkin(){
		CST.color = Color.grey;
		SceneManager.LoadScene ("Change skin");
	}
}
