using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool hasGameEnded = false;
	public int maxNumberOfMissilesOnScreen = 3;
	public int actualNumberOfMissilesOnScreen = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (this.hasGameEnded) {
			// TODO: do something
		}
	}
}
