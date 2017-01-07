using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Weight : MonoBehaviour {
	float ValMax = 100;
	float ValActual = 100;



	public Image barra;

	public Text valText;

	void Start(){
		
	}
	void Update(){
		valText.text = ValActual.ToString ();
	}

	void IntroValActual(float miBarra)
	{
		barra.fillAmount = miBarra;
	}

	void OnCollisionEnter(Collision col){
		
		if (col.gameObject.tag == "Missile") {
			ValActual -= 10;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

		if (col.gameObject.tag == "Laser") {
			ValActual -= 20;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

		if (col.gameObject.tag == "Arrow") {
			ValActual -= 20;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

		if (col.gameObject.tag == "Axe") {
			ValActual -= 25;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

		if (col.gameObject.tag == "Stone") {
			ValActual -= 35;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

	}
}
