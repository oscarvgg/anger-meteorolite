using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    //start function

    public void Start()
    {
        SceneManager.LoadScene("----");
    }
    //power up function
    public void PowerUp()
    {
        SceneManager.LoadScene("");

    }
    //setting function
    public void Setting()

    {
        SceneManager.LoadScene("");
    }
}

