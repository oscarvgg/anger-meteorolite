using UnityEngine;

public class FallBehaviour : MonoBehaviour {

	public GameObject meteor;
	public float fallSpeedIncrementor = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.MoveTowardsObject(meteor);
	}

	void MoveTowardsObject(GameObject player) {
		this.fallSpeedIncrementor += 0.0000000001f;
		var controller = player.GetComponent(typeof(PlayerController)) as PlayerController;
		var towardsPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		// transform.position = Vector3.MoveTowards(
		// 	transform.position, 
		// 	towardsPosition, 
		// 	controller.fallSpeed * Time.deltaTime);
		this.gameObject.GetComponent<Rigidbody>().velocity = transform.up * (controller.fallSpeed * (1+ this.fallSpeedIncrementor));
	}

}
