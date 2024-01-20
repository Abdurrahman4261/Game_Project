using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeviyelerYönetici : MonoBehaviour
{
    public Button seviye1_button, seviye2_button, seviye3_button,seviye4_button, seviye5_button;
    public static bool seviye1, seviye2,seviye3, seviye4, seviye5;
    // Start is called before the first frame update
    void Start()
    {
        seviye1 = true;
    }
    public void a1()
    {
        SceneManager.LoadScene(2);
    }
    public void a2()
    {
        SceneManager.LoadScene(3);
    }
    public void a3()
    {
        SceneManager.LoadScene(4);
    }
    public void a4()
    {
        SceneManager.LoadScene(5);
    }
    public void a5()
    {
        SceneManager.LoadScene(6);
    }
    // Update is called once per frame
    void Update()
    {
        if (seviye2 == true)
        {
            seviye2_button.interactable = true;
        }
        if (seviye3 == true)
        {
            seviye3_button.interactable = true;
        }
        if (seviye4 == true)
        {
            seviye4_button.interactable = true;
        }
        if (seviye5 == true)
        {
            seviye5_button.interactable = true;
        }
    }
}
