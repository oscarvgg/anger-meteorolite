using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolScriptPlanet3 : MonoBehaviour
{
	public GameObject swordObject;
	public GameObject rockObject;
	public GameObject trishulaObject;
	public GameObject building1;
	public GameObject building2;
	public GameObject building3;
	public bool willGrow = true;

	public List<GameObject> pooledObjects;
	public List<GameObject> rockObjects;
	public List<GameObject> trishulaObjects;

	float secondsCounter2=0;
	float secondsToCount2=3;
	int swordAmount;
	int rockAmount;
	int trishulaAmount;
	void Start ()
	{
		Attacks3 choosePart=GameObject.Find("Attacks3").GetComponent<Attacks3>() as Attacks3;
		swordAmount = choosePart.numberSword;
		rockAmount = choosePart.numberRock;
		trishulaAmount = choosePart.numberTrishula;
		float valueX = swordObject.transform.position.x;
		float valueY = swordObject.transform.position.y;
		float valueZ = swordObject.transform.position.z;
		pooledObjects = new List<GameObject>();
		for(int i = 0; i < swordAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(swordObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 0.5f, valueX + 0.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 0.5f, valueZ + 0.5f));
			pooledObjects.Add(obj);
		}
		for(int i = 0; i < rockAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(rockObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1.5f, valueX + 1.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			rockObjects.Add(obj);
		}

		for(int i = 0; i < trishulaAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(trishulaObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1f, valueX + 1f),Random.Range(-200f, 400f), Random.Range (valueZ - 1f, valueZ + 1f));
			trishulaObjects.Add(obj);
		}

		for (int i = 0; i < 150; i++) {
			GameObject obj = (GameObject)Instantiate(building1);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-535, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}

		for (int i = 0; i < 150; i++) {
			GameObject obj = (GameObject)Instantiate(building2);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-535, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}

		for (int i = 0; i < 150; i++) {
			GameObject obj = (GameObject)Instantiate(building3);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (-600, 600),-535, Random.Range (-600, 600));
			obj.transform.localScale = new Vector3 (10, 10, 10);
		}


	}










	public GameObject GetPooledObject()
	{
		for(int i = 0; i< pooledObjects.Count; i++)
		{
			if(pooledObjects[i] == null)
			{
				GameObject obj = (GameObject)Instantiate(swordObject);
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
			GameObject obj = (GameObject)Instantiate(swordObject);
			pooledObjects.Add(obj);
			return obj;
		}

		return null;
	}

}