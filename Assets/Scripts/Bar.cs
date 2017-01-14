using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum tipoBarra
{
	Weight, Height, Mana
}
public class Bar : MonoBehaviour {

	public GameObject meteor;
	public GameObject planet;
	float ValMax = 100;
	float ValActual = 100;

	public tipoBarra tipoDeBarra;

	public Image barra;

	public Text valText;
	float maxDistance;

	void Start(){
		maxDistance = Vector3.Distance (meteor.transform.position, planet.transform.position);
		valText.text = ValActual.ToString ();
	}

	void Update()
	{ 
		

		switch (tipoDeBarra)
		{
		case tipoBarra.Weight:
			break;

		case tipoBarra.Height:
			float valActu = Vector3.Distance (meteor.transform.position, planet.transform.position);
			float hambreBarra = valActu / maxDistance;
			IntroValActual(hambreBarra);
			valText.text = valActu.ToString ("0") + "Kilometers";
			break;
		}
	}

	void IntroValActual(float miBarra)
	{
		barra.fillAmount = miBarra;
	}

	void onCollisionEnter(Collider other){
		switch(tipoDeBarra){
		case tipoBarra.Weight:
			if (other.tag == "Missile") {
				ValActual -= 1;
				float vidaBarra = ValActual / ValMax;
				IntroValActual (vidaBarra);
				valText.text = ValActual.ToString ();
			}
			break;

		}
	}
}
