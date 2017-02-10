using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBackPlanets: MonoBehaviour
{
	public Button backB;
	public void back(){
		backB.GetComponent<Image> ().color = Color.grey;
		SceneManager.LoadScene ("Planets");
	}
}
