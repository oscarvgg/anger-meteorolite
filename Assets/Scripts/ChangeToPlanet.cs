using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToPlanet : MonoBehaviour {

	// Use this for initialization
	Ray ray;
	RaycastHit hit;

	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.touches.Length==1)
		{
			if (hit.collider.name == "PLANET1") {
				SceneManager.LoadScene ("ChoosePartOfPlanet1");
			} else if (hit.collider.name == "PLANET2") {
				SceneManager.LoadScene ("ChoosePartOfPlanet2");
			}
		}
	}
	

}
