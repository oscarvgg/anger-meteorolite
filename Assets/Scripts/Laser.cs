using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Laser: MonoBehaviour
{
	public float speed = -4;
	void Start(){
	}

	void Update(){
		this.transform.position += transform.up * -speed;
	}
}
