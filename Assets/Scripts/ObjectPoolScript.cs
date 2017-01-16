using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolScript : MonoBehaviour
{
	public GameObject missileObject;
	public GameObject laserObject;
	public GameObject lightObject;
	public GameObject building1;
	public GameObject building2;
	public GameObject building3;
	public GameObject building4;
	public GameObject meteor;
	public bool willGrow = true;

	public List<GameObject> pooledObjects;
	public List<GameObject> laserObjects;
	public List<GameObject> lightObjects;

	float secondsCounter=0;
	float secondsToCount=2;
	float secondsCounter2=0;
	float secondsToCount2=3;
	int laserAmount;
	int missileAmount;
	int lightAmount;
	void Start ()
	{
		Attacks1 choosePart=GameObject.Find("Attacks1").GetComponent<Attacks1>() as Attacks1;
		Debug.Log (choosePart.numberLaser);
		laserAmount = choosePart.numberLaser;
		missileAmount = choosePart.numberMissile;
		lightAmount = choosePart.numberLight;
		float valueX = meteor.transform.position.x;
		float valueY = meteor.transform.position.y;
		float valueZ = meteor.transform.position.z;
		pooledObjects = new List<GameObject>();
		for(int i = 0; i < missileAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(missileObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1f, valueX + 1f), Random.Range (-200f, 400f), Random.Range (valueZ - 1f, valueZ + 1f));
			pooledObjects.Add(obj);
		}
		for(int i = 0; i < laserAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(laserObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1f, valueX + 1f), Random.Range (-200f, 400f), Random.Range (valueZ - 1f, valueZ + 1f));
			laserObjects.Add(obj);
		}

		for(int i = 0; i < lightAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(lightObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1f, valueX + 1f),Random.Range (-200f, 400f), Random.Range (valueZ - 1f, valueZ + 1f));
			lightObjects.Add(obj);
		}

		for (int i = 0; i < 200; i++) {
			GameObject obj = (GameObject)Instantiate(building1);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-525, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);

		}

		for (int i = 0; i < 150; i++) {
			GameObject obj = (GameObject)Instantiate(building2);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-525, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}

		for (int i = 0; i < 100; i++) {
			GameObject obj = (GameObject)Instantiate(building3);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-525, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}

		for (int i = 0; i < 50; i++) {
			GameObject obj = (GameObject)Instantiate(building4);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-525, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}

	}

	
		







	public GameObject GetPooledObject()
	{
		for(int i = 0; i< pooledObjects.Count; i++)
		{
			if(pooledObjects[i] == null)
			{
				GameObject obj = (GameObject)Instantiate(missileObject);
				obj.SetActive(false);
				pooledObjects[i] = obj;
				return pooledObjects[i];
			}
			if(!pooledObjects[i].activeInHierarchy)
			{
				return pooledObjects[i];
			}    
		}

		if (willGrow)
		{
			GameObject obj = (GameObject)Instantiate(missileObject);
			pooledObjects.Add(obj);
			return obj;
		}

		return null;
	}

}