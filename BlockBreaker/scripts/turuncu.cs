using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turuncu : MonoBehaviour
{
    private int BlokSaglýk=3, hangihediye;
    public static int saglýk;
    private SpriteRenderer ressam;
    public TextMesh can;
    public AudioSource bloksesi;
    public Transform turuncuefect, artýhýz, artýboyut, yavas, kücük, hak;
    public Sprite sarisp,kiriksp;

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
            kazandik.skor += 30;
            bloksesi.Play();
        }
        if (BlokSaglýk == 0)
        {
            Instantiate(turuncuefect, temas.transform.position, temas.transform.rotation);
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

        if (BlokSaglýk == 2)
        {

            //ressam.material= renkk;
            can.text = "2";
            //ressam.color = renk;
            ressam.sprite = sarisp;
        }

        if (BlokSaglýk == 1)
        {

            //ressam.material= renkk;
            can.text = "1";
            //ressam.color = renk;
            ressam.sprite = kiriksp;
        }

    }
}
