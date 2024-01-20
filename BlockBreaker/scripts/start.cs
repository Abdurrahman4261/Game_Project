using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
  /*  public void quit()
    {
        Application.Quit();
    }*/
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
}
