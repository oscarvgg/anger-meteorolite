using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolScript : MonoBehaviour
{
	public GameObject missileObject;
	public GameObject laserObject;
	public bool willGrow = true;

	public List<GameObject> pooledObjects;
	public List<GameObject> laserObjects;

	float secondsCounter=0;
	float secondsToCount=2;
	int laserAmount;
	int missileAmount;
	void Start ()
	{
		ChoosePart choosePart=GameObject.Find("planet0").GetComponent<ChoosePart>() as ChoosePart;
		Debug.Log (choosePart.numberLaser);
		laserAmount = choosePart.numberLaser;
		missileAmount = choosePart.numberMissile;
		float valueX = missileObject.transform.position.x;
		float valueY = missileObject.transform.position.y;
		float valueZ = missileObject.transform.position.z;
		pooledObjects = new List<GameObject>();
		for(int i = 0; i < missileAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(missileObject);
			obj.SetActive(true);
			obj.transform.position = new Vector3 (Random.Range (valueX - 2.5f, valueX + 2.5f), Random.Range (-200f, 400f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			pooledObjects.Add(obj);
		}
		for(int i = 0; i < laserAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(laserObject);
			obj.SetActive(false);
			obj.transform.position = new Vector3 (Random.Range (valueX - 2.5f, valueX + 2.5f), -500f, Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			laserObjects.Add(obj);
		}


		}
	void Update(){
		secondsCounter += Time.deltaTime;
		if (secondsCounter >= secondsToCount && laserAmount!=0)
		{
			secondsCounter=0;
			laserAmount--;
			laserObjects [laserAmount].SetActive (true);
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