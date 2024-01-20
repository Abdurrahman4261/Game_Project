using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    // Start is called before the first frame update
    public void seviye1bitir()
    {

        SeviyelerYönetici.seviye2 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye2bitir()
    {

        SeviyelerYönetici.seviye3 = true;
        SceneManager.LoadScene(1);

    }

    public void seviye3bitir()
    {

        SeviyelerYönetici.seviye4 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye4bitir()
    {

        SeviyelerYönetici.seviye5 = true;
        SceneManager.LoadScene(1);

    }
    public void seviye5bitir()
    {
        SceneManager.LoadScene(1);

    }
}
