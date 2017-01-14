using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeskin : MonoBehaviour
{
    //  public string changeskin1 = "GameOver";
    public GameObject original;
	public Material meteor;
	public Texture basket;
	public Texture orange;


    // Use this for initialization
    public void ChangeToSceneNext()
    {
		if (original.GetComponent<Renderer> ().material.mainTexture==meteor.mainTexture)
        {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=orange;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = orange;

		}else if (original.GetComponent<Renderer> ().material.mainTexture==orange)
		{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=basket;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = basket;

        }
        else
        {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=meteor.mainTexture;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = meteor.mainTexture;
        }

    }
    public void ChangeToSceneBack()
    {

		if (original.GetComponent<Renderer> ().material.mainTexture==meteor.mainTexture)
		{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=basket;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = basket;

		}else if (original.GetComponent<Renderer> ().material.mainTexture==orange)
		{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=meteor.mainTexture;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = meteor.mainTexture;

		}
		else
		{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=orange;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = orange;
		}


	}
    public void GoBack()
    {
        SceneManager.LoadScene("MAINPAGE");

    }

}