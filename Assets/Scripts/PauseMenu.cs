using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public Transform canvas;
	public GameObject laser;
	public Transform power;
	public Transform player;
	public GameObject skin;
	public GameObject inv;
	public GameObject weight;
	public GameObject shield;





	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}
	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false)
		{
			if (GameObject.Find ("Laser") != null) {
				Laser las = GameObject.Find ("Laser").GetComponent<Laser> ();
				las.speed = 0;
			}
			if (GameObject.Find ("SlowLight") != null) {
				Light lig = GameObject.Find ("SlowLight").GetComponent<Light> ();
				lig.speed = 0;
			}
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;

		}
		else
		{
			if (GameObject.Find ("Laser") != null) {
				Laser las = GameObject.Find ("Laser").GetComponent<Laser> ();
				las.speed = -6;
			}
			if (GameObject.Find ("Slowlight") != null) {
				Light lig = GameObject.Find ("Slowlight").GetComponent<Light> ();
				lig.speed = -5;
			}
			canvas.gameObject.SetActive(false);
			Time.timeScale = 1;
		}
	}

	public void Menu(){
		SceneManager.LoadScene("MAINPAGE");
	}

	public void Resume(){
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
	}

	public void PowerUps(){
		if (power.gameObject.activeInHierarchy == false)
		{
			PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
			if (pum.lvInv == 0) {
				inv.SetActive (false);
			}
			if (pum.lvShield == 0) {
				shield.SetActive (false);
			}
			if (pum.lvWeight == 0) {
				weight.SetActive (false);
			}
			if (GameObject.Find ("Laser") != null) {
				Laser las = GameObject.Find ("Laser").GetComponent<Laser> ();
				las.speed = 0;
			}
			if (GameObject.Find ("SlowLight") != null) {
				Light lig = GameObject.Find ("SlowLight").GetComponent<Light> ();
				lig.speed = 0;
			}
			power.gameObject.SetActive(true);
			Time.timeScale = 0;

		}
		else
		{
			if (GameObject.Find ("Laser") != null) {
				Laser las = GameObject.Find ("Laser").GetComponent<Laser> ();
				las.speed = -6;
			}
			if (GameObject.Find ("SlowLight") != null) {
				Light lig = GameObject.Find ("SlowLight").GetComponent<Light> ();
				lig.speed = -5;
			}
			power.gameObject.SetActive(false);
			Time.timeScale = 1;
		}
	}

	public void Invincible(){
		skin.gameObject.SetActive (true);
		GameObject.Find ("Meteor").GetComponent<Weight> ().inv = true;
		power.gameObject.SetActive(false);
		Time.timeScale = 1;
		StartCoroutine (TimeInv());
	}

	IEnumerator TimeInv(){
		if(GameObject.Find("PowerUpsPlayer")!=null){
			PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
			yield return new WaitForSeconds (0.5f*pum.lvInv);
			skin.gameObject.SetActive (false);
			GameObject.Find ("Meteor").GetComponent<Weight> ().inv = false;
			inv.gameObject.SetActive (false);

		}
	}

	public void Weight(){
		if(GameObject.Find("PowerUpsPlayer")!=null){
			PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
			float amountAdd = 20 * pum.lvWeight;
			GameObject.Find ("Meteor").GetComponent<Weight> ().ValActual += 20;
			GameObject.Find ("Meteor").GetComponent<Weight> ().ValMax += 20;
			weight.gameObject.SetActive (false);

		}
			
	}

	public void Shield(){
		if(GameObject.Find("PowerUpsPlayer")!=null){
			PowerUpsMeteor pum = GameObject.Find ("PowerUpsPlayer").GetComponent<PowerUpsMeteor> ();
			float amountAdd = 1 * pum.lvShield;
			GameObject.Find ("Meteor").GetComponent<Weight> ().amountShield = amountAdd;
			shield.gameObject.SetActive (false);

		}

	}
}


