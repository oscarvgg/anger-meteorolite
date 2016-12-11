using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoosePart : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	void Update()
	{
		var rotationComponent = this.gameObject.GetComponent(typeof(rotPlanets)) as rotPlanets;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0) && !rotationComponent.isRotating)
		{
			if (hit.collider.name == "WHITE") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE2") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "BLUE1") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE1") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE2") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE3") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE4") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE5") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE3") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE4") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE1") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE2") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE3") 
			{
				SceneManager.LoadScene("PlayerController_Test");
			}
		}
	}



}
