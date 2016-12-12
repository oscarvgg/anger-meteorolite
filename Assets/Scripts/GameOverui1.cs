using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public string gameLevel1 = "MAINMENU";

    public void Mainmenu()
    {
        // Application.LoadLevel(gameLevel1);
        SceneManager.LoadScene(gameLevel1);
    }
    public void exit()
    { 
       
        Application.Quit();

    }
  

}
