using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolScriptPlanet2 : MonoBehaviour
{
	public GameObject arrowObject;
	public GameObject axeObject;
	public GameObject stoneObject;
	public GameObject building1;
	public GameObject building2;
	public GameObject building3;
	public bool willGrow = true;

	public List<GameObject> pooledObjects;
	public List<GameObject> axeObjects;
	public List<GameObject> stoneObjects;

	float secondsCounter2=0;
	float secondsToCount2=3;
	int arrowAmount;
	int axeAmount;
	int stoneAmount;
	void Start ()
	{
		Attacks2 choosePart=GameObject.Find("Attacks2").GetComponent<Attacks2>() as Attacks2;
		Debug.Log (choosePart.numberArrow);
		arrowAmount = choosePart.numberArrow;
		axeAmount = choosePart.numberAxe;
		stoneAmount = choosePart.numberStone;
		float valueX = arrowObject.transform.position.x;
		float valueY = arrowObject.transform.position.y;
		float valueZ = arrowObject.transform.position.z;
		pooledObjects = new List<GameObject>();
		for(int i = 0; i < arrowAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(arrowObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1.5f, valueX + 1.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			pooledObjects.Add(obj);
		}
		for(int i = 0; i < axeAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(axeObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1.5f, valueX + 1.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			axeObjects.Add(obj);
		}

		for(int i = 0; i < stoneAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(stoneObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 1.5f, valueX + 1.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			stoneObjects.Add(obj);
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
				GameObject obj = (GameObject)Instantiate(arrowObject);
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
			GameObject obj = (GameObject)Instantiate(arrowObject);
			pooledObjects.Add(obj);
			return obj;
		}

		return null;
	}

}