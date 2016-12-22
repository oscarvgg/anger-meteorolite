using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum tipoBarra
{
	Weight, Hambre, Mana
}
public class Bar : MonoBehaviour {

	public tipoBarra tipoDeBarra;

	public Image barra;

	public Text valText;

	private float ValMax = 100;

	private float ValActu = 100;

	void Update()
	{
		valText.text = tipoDeBarra + ": " + ValActu.ToString();

		if (ValActu >= ValMax)
		{
			ValActu = ValMax;
		}

		if (ValActu <= 0)
		{
			ValActu = 0;
		}

		switch (tipoDeBarra)
		{
		case tipoBarra.Weight:
			if (Input.GetKeyDown(KeyCode.B))
				{
					ValActu -= 1;
					float vidaBarra = ValActu / ValMax;
					IntroValActual(vidaBarra);
				}
			break;

		case tipoBarra.Hambre:
			if (Input.GetKeyDown(KeyCode.H))
			{
				ValActu -= 1;
				float hambreBarra = ValActu / ValMax;
				IntroValActual(hambreBarra);
			}
			break;
		case tipoBarra.Mana:
			if (Input.GetKeyDown(KeyCode.M))
			{
				ValActu -= 1;
				float manaBarra = ValActu / ValMax;
				IntroValActual(manaBarra);

			}
			break;
		}
	}

	void IntroValActual(float miBarra)
	{
		barra.fillAmount = miBarra;
	}

	void onTriggerEnter(Collider other){
		if (other.gameObject.tag == "Missile") {
			ValActu -= 1;
			float vidaBarra = ValActu / ValMax;
			IntroValActual(vidaBarra);
		}
	}
}
