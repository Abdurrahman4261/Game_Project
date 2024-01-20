using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesil_blok : MonoBehaviour
{
    private int blokSagligi=1, hangihediye;
    public Transform yesilefect;
    public AudioSource bloksesi;
    public Transform hediye,yavas, boyut,h�z,k�c�k,hak;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        hangihediye = Random.Range(1, 6);

        Debug.Log("hangi hediye:" + hangihediye);

        if (temas.gameObject.tag == "Top")

        {
            bloksesi.Play();
            blokSagligi--;
            kazandik.skor += 10;
            
        }
        if (blokSagligi == 0)
        {
            Instantiate(yesilefect, temas.transform.position, temas.transform.rotation);
            Destroy(this.gameObject);
            kazandik.kirilanBlok ++;
            if (hangihediye == 1)
            {
                Instantiate(boyut, transform.position, boyut.rotation);
            }
            if (hangihediye == 2)
            {
               
                Instantiate(h�z, transform.position, h�z.rotation);
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
    }
}
