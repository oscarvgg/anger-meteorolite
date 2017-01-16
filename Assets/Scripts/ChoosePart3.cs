using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoosePart3 : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public int numberSword = 10;
	public int numberRock = 5;
	public int numberTrishula = 1;
	public GameObject attacks;


	void Update()
	{
		var rotationComponent = this.gameObject.GetComponent(typeof(rotPlanets)) as rotPlanets;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0) && !rotationComponent.isRotating)
		{
			if (hit.collider.name == "WHITE") 
			{
				numberSword = 10;
				numberRock = 5;
				numberTrishula = 1;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "WHITE2") 
			{
				numberSword = 10;
				numberRock = 5;
				numberTrishula = 1;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "BLUE1") 
			{
				numberSword = 30;
				numberRock = 15;
				numberTrishula = 6;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "PURPLE1") 
			{
				numberSword = 23;
				numberRock = 10;
				numberTrishula = 4;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");

			}
			if (hit.collider.name == "PURPLE2") {
				numberSword = 23;
				numberRock = 10;
				numberTrishula = 4;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "WHITE3") 
			{
				numberSword = 10;
				numberRock = 5;
				numberTrishula = 1;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "WHITE4") 
			{
				numberSword = 10;
				numberRock = 5;
				numberTrishula = 1;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "WHITE5") {
				numberSword = 10;
				numberRock = 5;
				numberTrishula = 1;
				attacks.GetComponent<Attacks3> ().numberSword = numberSword;
				attacks.GetComponent<Attacks3> ().numberRock = numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula = numberTrishula;
				SceneManager.LoadScene ("PlayerController3");
			}
			if (hit.collider.name == "PURPLE3") 
			{
				numberSword = 23;
				numberRock = 10;
				numberTrishula = 4;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "PURPLE4") 
			{
				numberSword = 23;
				numberRock = 10;
				numberTrishula = 4;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "ORANGE1") 
			{
				numberSword = 20;
				numberRock = 7;
				numberTrishula = 2;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "ORANGE2") 
			{
				numberSword = 20;
				numberRock = 7;
				numberTrishula = 2;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}
			if (hit.collider.name == "ORANGE3") 
			{
				numberSword = 20;
				numberRock = 7;
				numberTrishula = 2;
				attacks.GetComponent<Attacks3> ().numberSword=numberSword;
				attacks.GetComponent<Attacks3> ().numberRock=numberRock;
				attacks.GetComponent<Attacks3> ().numberTrishula=numberTrishula;
				SceneManager.LoadScene("PlayerController3");
			}

		}
	}



}
