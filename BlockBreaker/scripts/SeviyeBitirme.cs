using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    // Start is called before the first frame update
    public void seviye1bitir()
    {

        SeviyelerY�netici.seviye2 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye2bitir()
    {

        SeviyelerY�netici.seviye3 = true;
        SceneManager.LoadScene(1);

    }

    public void seviye3bitir()
    {

        SeviyelerY�netici.seviye4 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye4bitir()
    {

        SeviyelerY�netici.seviye5 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye5bitir()
    {
        SceneManager.LoadScene(1);

    }
}
