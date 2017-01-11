using UnityEngine;

public class FallBehaviour1 : MonoBehaviour {

	public GameObject meteor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.MoveTowardsObject(meteor);
	}

	void MoveTowardsObject(GameObject player) {
		var controller = player.GetComponent(typeof(PlayerController)) as PlayerController;
		var towardsPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		transform.position = Vector3.MoveTowards(
			transform.position, 
			towardsPosition, 
			controller.fallSpeed * Time.deltaTime);
	}

}
