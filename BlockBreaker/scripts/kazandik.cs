using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class kazandik : MonoBehaviour
{
    public GameObject puanobje, topobje;
    public TextMesh kazandikYazisi, puanYazisi;
    private int blokSayisi;
    public static int skor, kirilanBlok;
    public Canvas bitir;
    public Transform hediye, boyut,hýz,yavas, bloklar, playerobje;
    void Start()
    {
        skor = 0;
        kirilanBlok = 0;
        Time.timeScale = 1;
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.name == "bloklar")
        {
            puanYazisi.text = "Puan : " + skor;
        }
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (puanobje != null)
        {
            puanYazisi.text = "Puan : " + skor;
        }
        if (Time.timeScale == 1)
        {
            blokSayisi = bloklar.childCount;
            

        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("blok sayisi: " + blokSayisi);
        }
        if (Input.GetKeyDown(KeyCode.O)|| kirilanBlok == 66)
        {
            if (kirilanBlok == 66)
            {
                bloklar.transform.position = new Vector2(0, 20);
                kazandikYazisi.text = "Tebrikler Oyunu Bitirdiniz\n Puaniniz:" + skor + "\nKirdiginiz Blok:" + kirilanBlok;
                Time.timeScale = 0;
                Destroy(puanobje.gameObject);
                Destroy(topobje.gameObject);
                bitir.enabled = true;
            }
            else
            {
                bloklar.transform.position = new Vector2(0, 20);
                Time.timeScale = 0;
                Destroy(puanobje.gameObject);
                Destroy(topobje.gameObject);
                bitir.enabled = true;
            }
        }
        else if (blokSayisi == 0  )
        {
            
            kazandikYazisi.text= "\n\nTebrikler Kazandiniz\n Puaniniz:"+skor+"\nKirdiginiz Blok:" +kirilanBlok+"\n\nTekrar oynamak icin a tusuna basin";
            Time.timeScale = 0;
            Destroy(puanobje.gameObject);
            Destroy(topobje.gameObject);
            bitir.enabled =true;
            if (Input.GetKeyDown (KeyCode.A))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
