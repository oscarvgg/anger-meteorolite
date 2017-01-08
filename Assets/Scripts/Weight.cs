using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Weight : MonoBehaviour {
	public float ValMax = 100;
	public float ValActual = 100;
	public bool inv=false;
	public float amountShield=0;



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
		if (inv == false) {
			if (col.gameObject.tag == "Missile" && amountShield<=0) {
				ValActual -= 10;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}

			if (col.gameObject.tag == "Laser" && amountShield<=0) {
				ValActual -= 20;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}

			if (col.gameObject.tag == "Arrow" && amountShield<=0) {
				ValActual -= 20;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}

			if (col.gameObject.tag == "Axe" && amountShield<=0) {
				ValActual -= 25;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}

			if (col.gameObject.tag == "Stone" && amountShield<=0) {
				ValActual -= 35;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}
			amountShield--;
				
		}

	}
}
