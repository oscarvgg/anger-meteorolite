using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoosePart : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public int numberMissile=15;
	public int numberLaser=3;
	public int numberLight=0;


	void Update()
	{
		var rotationComponent = this.gameObject.GetComponent(typeof(rotPlanets)) as rotPlanets;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0) && !rotationComponent.isRotating)
		{
			if (hit.collider.name == "WHITE") 
			{
				numberMissile = 15;
				numberLaser = 3;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE2") 
			{
				numberMissile = 15;
				numberLaser = 3;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "BLUE1") 
			{
				numberMissile = 50;
				numberLaser = 10;
				numberLight = 5;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE1") 
			{
				numberMissile = 35;
				numberLaser = 7;
				numberLight = 3;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE2") 
			{
				numberMissile = 35;
				numberLaser = 7;
				numberLight = 3;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE3") 
			{
				numberMissile = 15;
				numberLaser = 3;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE4") 
			{
				numberMissile = 15;
				numberLaser = 3;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "WHITE5") 
			{
				numberMissile = 15;
				numberLaser = 3;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE3") 
			{
				numberMissile = 35;
				numberLaser = 7;
				numberLight = 3;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "PURPLE4") 
			{
				numberMissile = 35;
				numberLaser = 7;
				numberLight = 3;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE1") 
			{
				numberMissile = 25;
				numberLaser = 5;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE2") 
			{
				numberMissile = 25;
				numberLaser = 5;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			if (hit.collider.name == "ORANGE3") 
			{
				numberMissile = 25;
				numberLaser = 5;
				numberLight = 0;
				SceneManager.LoadScene("PlayerController_Test");
			}
			DontDestroyOnLoad (gameObject);
		}
	}



}
