using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Laser: MonoBehaviour
{
	void Start(){
	}

	void Update(){
		this.transform.position += transform.forward * -6;
	}
}
