using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoosePart2 : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public int numberArrow = 10;
	public int numberAxe = 5;
	public int numberStone = 1;



	void Update()
	{
		Attacks2 attacks = GameObject.Find ("Attacks2").GetComponent<Attacks2> ();
		var rotationComponent = this.gameObject.GetComponent(typeof(rotPlanets)) as rotPlanets;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && (Input.touches.Length==1 || Input.GetMouseButtonUp(0)) && !rotationComponent.isRotating)
		{
			if (hit.collider.name == "WHITE") 
			{
				numberArrow = 10;
				numberAxe = 5;
				numberStone = 1;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "WHITE2") 
			{
				numberArrow = 10;
				numberAxe = 5;
				numberStone = 1;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "BLUE1") 
			{
				numberArrow = 30;
				numberAxe = 15;
				numberStone = 6;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "PURPLE1") 
			{
				numberArrow = 23;
				numberAxe = 10;
				numberStone = 4;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");

			}
			if (hit.collider.name == "PURPLE2") 
			{
				numberArrow = 23;
				numberAxe = 10;
				numberStone = 4;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "WHITE3") 
			{
				numberArrow = 10;
				numberAxe = 5;
				numberStone = 1;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "WHITE4") 
			{
				numberArrow = 10;
				numberAxe = 5;
				numberStone = 1;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "WHITE5") 
			{
				numberArrow = 10;
				numberAxe = 5;
				numberStone = 1;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "PURPLE3") 
			{
				numberArrow = 23;
				numberAxe = 10;
				numberStone = 4;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "PURPLE4") 
			{
				numberArrow = 23;
				numberAxe = 10;
				numberStone = 4;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "ORANGE1") 
			{
				numberArrow = 20;
				numberAxe = 7;
				numberStone = 2;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "ORANGE2") 
			{
				numberArrow = 20;
				numberAxe = 7;
				numberStone = 2;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}
			if (hit.collider.name == "ORANGE3") 
			{
				numberArrow = 20;
				numberAxe = 7;
				numberStone = 2;
				attacks.numberArrow=numberArrow;
				attacks.numberAxe=numberAxe;
				attacks.numberStone=numberStone;
				SceneManager.LoadScene("PlayerController2");
			}

		}
	}



}
