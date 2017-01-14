using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Light: MonoBehaviour
{
	public float speed = -5;
	void Start(){
	}

	void Update(){
		this.transform.position += transform.up * speed;
	}
}
