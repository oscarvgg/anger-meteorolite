using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolScript : MonoBehaviour
{
	public GameObject missileObject;
	public GameObject laserObject;
	public GameObject lightObject;
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

		for(int i = 0; i < lightAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(lightObject);
			obj.SetActive(false);
			obj.transform.position = new Vector3 (Random.Range (valueX - 2.5f, valueX + 2.5f),Random.Range(-500f, -300f), Random.Range (valueZ - 1.5f, valueZ + 1.5f));
			lightObjects.Add(obj);
		}


		}
	void Update(){
		secondsCounter += Time.deltaTime;
		secondsCounter2 += Time.deltaTime;
		if (secondsCounter >= secondsToCount && laserAmount!=0)
		{
			secondsCounter=0;
			laserAmount--;
			laserObjects [laserAmount].SetActive (true);
		}

		if (secondsCounter2 >= secondsToCount2 && lightAmount!=0)
		{
			secondsCounter2=0;
			lightAmount--;
			lightObjects [lightAmount].SetActive (true);
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