using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mor : MonoBehaviour
{
    private int BlokSagl�k=4, hangihediye;
    public static int sagl�k;
    private SpriteRenderer ressam;
    public TextMesh can;
    public AudioSource bloksesi;
    public Transform morefect, art�h�z, art�boyut, yavas, k�c�k,hak;
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
            BlokSagl�k--;
            
            bloksesi.Play();
        }
        if (BlokSagl�k == 0)
        {
            kazandik.skor += 40;
            Instantiate(morefect, temas.transform.position, temas.transform.rotation);
            Destroy(this.gameObject);
            kazandik.kirilanBlok++;
            if (hangihediye == 1)
            {
                Instantiate(art�boyut, transform.position, art�boyut.rotation);
            }
            if (hangihediye == 2)
            {

                Instantiate(art�h�z, transform.position, art�h�z.rotation);

            }

            if (hangihediye == 3)
            {
                Instantiate(yavas, transform.position, yavas.rotation);
            }

            if (hangihediye == 4)
            {

                Instantiate(k�c�k, transform.position, k�c�k.rotation);
            }

            if (hangihediye == 5)
            {

                Instantiate(hak, transform.position, hak.rotation);
            }
        }

        if (BlokSagl�k == 3)
        {
            can.text = "3";
        }

        if (BlokSagl�k == 2)
        {     
            can.text = "2";   
        }

        if (BlokSagl�k == 1)
        {
            can.text = "1";
            ressam.sprite = kiriksp;
        }
    }
}
