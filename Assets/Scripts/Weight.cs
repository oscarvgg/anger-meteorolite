using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Weight : MonoBehaviour {
	public float ValMax = 100;
	public float ValActual = 100;
	public bool inv=false;
	public float amountShield=0;
	public GameObject gameC1;
	public GameObject gameC2;
	public GameObject gameC3;



	public Image barra;

	public Text valText;

	void Start(){
		
	}
	void Update(){
		valText.text = ValActual.ToString ();
		if (ValActual <= 0) {
			if (gameC1 != null) {
				StartCoroutine (Died1 ());
			} else if (gameC2 != null) {
				StartCoroutine (Died2 ());
			} else if (gameC3 != null) {
				StartCoroutine (Died3 ());
			}
		}
	}

	IEnumerator Died1(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("GAME OVER1");
	}
	IEnumerator Died2(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("GAME OVER2");
	}
	IEnumerator Died3(){
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene ("GAME OVER3");
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
			if (col.gameObject.tag == "Sword" && amountShield<=0) {
				ValActual -= 15;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}
			if (col.gameObject.tag == "Rock" && amountShield<=0) {
				ValActual -= 20;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}
			if (col.gameObject.tag == "Trishula" && amountShield<=0) {
				ValActual -= 30;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);

			}
			amountShield--;
				
		}

	}
}
