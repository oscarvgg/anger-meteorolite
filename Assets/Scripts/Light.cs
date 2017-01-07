using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Light: MonoBehaviour
{
	void Start(){
	}

	void Update(){
		this.transform.position += transform.up * -5;
	}
}
