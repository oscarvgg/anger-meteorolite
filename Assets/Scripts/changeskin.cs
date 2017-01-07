using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeskin : MonoBehaviour
{
    //  public string changeskin1 = "GameOver";
    public GameObject original;
    public GameObject orange;
    public GameObject basketball;

    // Use this for initialization
    public void ChangeToSceneNext()
    {
        if (original.activeSelf)
        {
            orange.gameObject.SetActive(true);
            original.gameObject.SetActive(false);

        }else if (orange.activeSelf)
        {
            orange.gameObject.SetActive(false);
            basketball.gameObject.SetActive(true);

        }
        else
        {
            basketball.gameObject.SetActive(false);
            original.gameObject.SetActive(true);
        }

    }
    public void ChangeToSceneBack()
    {
        if (original.activeSelf)
        {
            basketball.gameObject.SetActive(true);
            original.gameObject.SetActive(false);

        }
        else if (orange.activeSelf)
        {
            orange.gameObject.SetActive(false);
            original.gameObject.SetActive(true);

        }
        else
        {
            basketball.gameObject.SetActive(false);
            orange.gameObject.SetActive(true);
        }

    }
    public void GoBack()
    {
        SceneManager.LoadScene("MAINPAGE");

    }

}