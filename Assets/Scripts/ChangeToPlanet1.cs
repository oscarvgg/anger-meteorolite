using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToPlanet1 : MonoBehaviour {

	// Use this for initialization
	Ray ray;
	RaycastHit hit;

	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
		{
			if (hit.collider.name == "PLANET0") 
			{
				SceneManager.LoadScene("ChoosePartOfPlanet");
			}
		}
	}
	

}
