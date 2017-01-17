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
	public Texture hole;
	public Texture sun;
	public Texture magic;


    // Use this for initialization
    public void ChangeToSceneNext()
    {
		if (original.GetComponent<Renderer> ().material.mainTexture == meteor.mainTexture) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = orange;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = orange;

		}else if (original.GetComponent<Renderer> ().material.mainTexture == orange) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = basket;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = basket;

		}else if (original.GetComponent<Renderer> ().material.mainTexture == basket) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = hole;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = hole;
		}else if (original.GetComponent<Renderer> ().material.mainTexture == hole) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = sun;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = sun;
		}else if (original.GetComponent<Renderer> ().material.mainTexture == sun) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = magic;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = magic;
		}else{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=meteor.mainTexture;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = meteor.mainTexture;
        }

    }
    public void ChangeToSceneBack()
    {

		if (original.GetComponent<Renderer> ().material.mainTexture==meteor.mainTexture){
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=magic;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = magic;

		}else if (original.GetComponent<Renderer> ().material.mainTexture==magic){
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=sun;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = sun;

		}else if (original.GetComponent<Renderer> ().material.mainTexture == sun) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = hole;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = hole;
		}else if (original.GetComponent<Renderer> ().material.mainTexture == hole) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = basket;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = basket;
		}else if (original.GetComponent<Renderer> ().material.mainTexture == basket) {
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture = orange;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = orange;
		}else{
			original.GetComponent<Renderer> ().sharedMaterial.mainTexture=meteor.mainTexture;
			GameObject.Find ("TypeSkin").GetComponent<Skin> ().skin = meteor.mainTexture;
		}


	}
    public void GoBack()
    {
        SceneManager.LoadScene("MAINPAGE");

    }

}