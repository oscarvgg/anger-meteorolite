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
			Debug.Log ("Hola");
			ValActual -= 1;
			float vidaBarra = ValActual / ValMax;
			IntroValActual (vidaBarra);

		}

	}
}
