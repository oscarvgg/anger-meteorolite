using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Attacks1 : MonoBehaviour {


	public int numberMissile = 10;
	public int numberLaser = 5;
	public int numberLight = 1;


	void Update()
	{
		if (GameObject.Find ("planet0") != null) {
			ChoosePart choose = GameObject.Find ("planet0").GetComponent<ChoosePart> ();
			numberMissile = choose.numberMissile;
			numberLaser = choose.numberLaser;
			numberLight = choose.numberLight;
			DontDestroyOnLoad (gameObject);
		}

		}
	}




