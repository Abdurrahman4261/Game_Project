using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mor : MonoBehaviour
{
    private int BlokSaglýk=4, hangihediye;
    public static int saglýk;
    private SpriteRenderer ressam;
    public TextMesh can;
    public AudioSource bloksesi;
    public Transform morefect, artýhýz, artýboyut, yavas, kücük,hak;
    public Sprite kiriksp;
    public Transform bloklar;

    void Start()
    {
        ressam = GetComponent<SpriteRenderer>();
        
    }
    void cann()
    {
        can = GetComponent<TextMesh>();
    }



    private void OnCollisionEnter2D(Collision2D temas)
    {
        hangihediye = Random.Range(1, 6);

        Debug.Log("hangi hediye:" + hangihediye);

        if (temas.gameObject.tag == "Top")
        {
            BlokSaglýk--;
            
            bloksesi.Play();
        }
        if (BlokSaglýk == 0)
        {
            kazandik.skor += 40;
            Instantiate(morefect, temas.transform.position, temas.transform.rotation);
            Destroy(this.gameObject);
            kazandik.kirilanBlok++;
            if (hangihediye == 1)
            {
                Instantiate(artýboyut, transform.position, artýboyut.rotation);
            }
            if (hangihediye == 2)
            {

                Instantiate(artýhýz, transform.position, artýhýz.rotation);

            }

            if (hangihediye == 3)
            {
                Instantiate(yavas, transform.position, yavas.rotation);
            }

            if (hangihediye == 4)
            {

                Instantiate(kücük, transform.position, kücük.rotation);
            }

            if (hangihediye == 5)
            {

                Instantiate(hak, transform.position, hak.rotation);
            }
        }

        if (BlokSaglýk == 3)
        {
            can.text = "3";
        }

        if (BlokSaglýk == 2)
        {     
            can.text = "2";   
        }

        if (BlokSaglýk == 1)
        {
            can.text = "1";
            ressam.sprite = kiriksp;
        }
    }
}
