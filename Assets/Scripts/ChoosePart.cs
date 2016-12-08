using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoosePart : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
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
		}
	}



}
