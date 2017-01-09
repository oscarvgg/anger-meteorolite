using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Attacks2 : MonoBehaviour {


	public int numberArrow = 10;
	public int numberAxe = 5;
	public int numberStone = 1;


	void Update()
	{
		if (GameObject.Find ("planet2") != null) {
			ChoosePart2 choose = GameObject.Find ("planet2").GetComponent<ChoosePart2> ();
			numberArrow = choose.numberArrow;
			numberAxe = choose.numberAxe;
			numberStone = choose.numberStone;
			DontDestroyOnLoad (gameObject);
		}

		}
	}




