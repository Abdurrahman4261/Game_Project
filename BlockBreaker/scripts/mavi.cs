using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mavi : MonoBehaviour
{
    private int BlokSagl�k = 2, hangihediye;
    public static int sagl�k;
    private SpriteRenderer ressam;
    public TextMesh can;
    public AudioSource bloksesi;
    public Transform maviefect,art�h�z,art�boyut,yavas,k�c�k,hak;
    public Color renk;

    void Start()
    {
        ressam = GetComponent<SpriteRenderer>();
    }
    void cann()
    {
        can = GetComponent<TextMesh>();
    }



    private void OnCollisionEnter2D(Collision2D temas) {
        hangihediye = Random.Range(1, 6);
        Debug.Log("hangi hediye:" + hangihediye);
        if (temas.gameObject.tag == "Top")
        {
            BlokSagl�k--;
            kazandik.skor += 20;
            bloksesi.Play();
        }
        if (BlokSagl�k == 0)
        {
            Instantiate(maviefect, temas.transform.position, temas.transform.rotation);
            Destroy(this.gameObject);
            kazandik.kirilanBlok ++;
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
        if (BlokSagl�k == 1)
        {
             
            can.text = "1";
            ressam.color = renk;
        }
        
    }
}
