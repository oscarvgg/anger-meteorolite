using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Attacks3 : MonoBehaviour {


	public int numberSword = 10;
	public int numberRock = 5;
	public int numberTrishula = 1;
	public static Attacks3 script;


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
		if (GameObject.Find ("planet3") != null) {
			ChoosePart3 choose = GameObject.Find ("planet3").GetComponent<ChoosePart3> ();
			numberSword = choose.numberSword;
			numberRock = choose.numberRock;
			numberTrishula = choose.numberTrishula;
		}

		}
	}




