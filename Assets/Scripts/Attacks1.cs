using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Attacks1 : MonoBehaviour {


	public int numberMissile = 10;
	public int numberLaser = 5;
	public int numberLight = 1;
	public static Attacks1 script;


	void Awake(){
		if (script == null) {
			script = this;
			DontDestroyOnLoad (gameObject);
		} else if (script != this) {

			Destroy (gameObject);
		}
	}

	void Update()
	{
		if (GameObject.Find ("planet1") != null) {
			ChoosePart choose = GameObject.Find ("planet1").GetComponent<ChoosePart> ();
			numberMissile = choose.numberMissile;
			numberLaser = choose.numberLaser;
			numberLight = choose.numberLight;
		}

		}
	}




