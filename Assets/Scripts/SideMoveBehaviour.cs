using UnityEngine;
using System.Collections;

public class SideMoveBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		var movePosition = this.GetClickPosition();
		var controller = this.gameObject.GetComponent(typeof(PlayerController)) as PlayerController;
		if (movePosition != null) {
			this.MoveTowardsPosition((Vector3) movePosition);
			controller.isUnderPlayerControl = true;
		}
		else {
			controller.isUnderPlayerControl = false;
		}
	}

	Vector3? GetClickPosition() {
		if (!Input.GetMouseButton(0)) {
			return null;
		}
		var clickPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
		Vector3 worldClickPosition = Camera.main.ScreenToWorldPoint(clickPosition);
		return worldClickPosition;
	}

	void MoveTowardsPosition(Vector3 clickPosition) {
		var controller = this.gameObject.GetComponent(typeof(PlayerController)) as PlayerController;
		var towardsPosition = new Vector3(clickPosition.x, clickPosition.y, transform.position.z);
		transform.position = Vector3.MoveTowards(
			transform.position, 
			towardsPosition, 
			controller.horizontalSpeed * Time.deltaTime);
	}
}
