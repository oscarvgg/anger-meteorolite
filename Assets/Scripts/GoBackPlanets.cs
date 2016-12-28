using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoBackPlanets: MonoBehaviour
{
	public void back(){
		SceneManager.LoadScene ("Planets");
	}
}
