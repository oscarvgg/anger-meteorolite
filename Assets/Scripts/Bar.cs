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

	public tipoBarra tipoDeBarra;

	public Image barra;

	public Text valText;
	float maxDistance;

	void Start(){
		maxDistance = Vector3.Distance (meteor.transform.position, planet.transform.position);
	}

	void Update()
	{ 
		

		switch (tipoDeBarra)
		{
		case tipoBarra.Weight:
			float ValMax = 100;
			float ValActu = 100;
			if (Input.GetKeyDown(KeyCode.B))
			{
					ValActu -= 1;
					float vidaBarra = ValActu / ValMax;
					IntroValActual(vidaBarra);
					valText.text = tipoDeBarra + ": " + ValActu.ToString();
				}
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

	void onTriggerEnter(Collider other){
		float ValMax = 100;
		float ValActu = 100;
		if (other.gameObject.tag == "Missile") {
			ValActu -= 1;
			float vidaBarra = ValActu / ValMax;
			IntroValActual(vidaBarra);
		}
	}
}
