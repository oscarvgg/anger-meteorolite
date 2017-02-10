using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoBackMenu: MonoBehaviour
{
	public Button backB;
	public void back(){
		backB.GetComponent<Image> ().color = Color.grey;
		SceneManager.LoadScene ("MAINPAGE");
	}
}
