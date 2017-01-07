using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeskin : MonoBehaviour
{
    //  public string changeskin1 = "GameOver";
    public GameObject original;
	public Material[] materials;

    // Use this for initialization
    public void ChangeToSceneNext()
    {
		if (original.GetComponent<Renderer> ().material==materials[0])
        {
			original.GetComponent<Renderer> ().sharedMaterial = materials [1];

		}else if (original.GetComponent<Renderer> ().material==materials[1])
        {
			original.GetComponent<Renderer> ().sharedMaterial = materials [2];

        }
        else
        {
			original.GetComponent<Renderer> ().sharedMaterial = materials [0];
        }

    }
    public void ChangeToSceneBack()
    {
		if (original.GetComponent<Renderer> ().material==materials[0])
		{
			original.GetComponent<Renderer> ().sharedMaterial = materials [2];

		}else if (original.GetComponent<Renderer> ().material==materials[1])
		{
			original.GetComponent<Renderer> ().sharedMaterial = materials [0];

		}
		else
		{
			original.GetComponent<Renderer> ().sharedMaterial = materials [1];
		}


    }
    public void GoBack()
    {
        SceneManager.LoadScene("MAINPAGE");

    }

}