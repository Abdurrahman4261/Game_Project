using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class top_etkilesimi : MonoBehaviour
{
    public Rigidbody2D top;
    public float yatayHiz,dikeyHiz;
    public float speed = 8f;
    public GameObject puanyazi, topobje, playerobje,bloklar,playerorta,a,b;
    public TextMesh kazandikyazisi, hakyazi,hizyazi;
    public static int hak=3;
    private int m = 0;
  
    void Start() {

        GetComponent<Rigidbody2D>().velocity = Vector2.up * -dikeyHiz;

        hakyazi.text = "Hak:" + hak;
    }

    void Update()
    {
        if (m == 1)
        {
            --hak;
            hakyazi.text = "Hak:" + hak;
            m = 0;

        }
        if (player_hareket.m == 3)
        {
            Debug.Log("hak");
            ++hak;
            hakyazi.text = "Hak:" + hak;
            player_hareket.m = 0;
        }
        if(Input.GetMouseButtonDown(0)){
            a.SetActive(false);        
        }
        else  if (Input.GetMouseButtonDown(1))
        {
            a.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D temas) {

        
        if (temas.gameObject.tag == "Player" )
        {
            top.velocity = new Vector2(top.velocity.x, top.velocity.y);
        }
        if (temas.gameObject.tag == "playersol")
        {
             
           
            if (top.velocity.x >= 0f) { 
                top.velocity = new Vector2(top.velocity.x + 3, top.velocity.y);
            }
            if (top.velocity.x < 0f)
            {
                top.velocity = new Vector2(top.velocity.x -3, top.velocity.y);
            }
        }



        if (temas.gameObject.tag == "playersag")
        {
            top.velocity = new Vector2(top.velocity.x, top.velocity.y + 0.5f);
        }




        if (temas.gameObject.tag == "SolDuvar"){
        top.velocity = new Vector2 (yatayHiz-2f,top.velocity.y);
        }

        if(temas.gameObject.tag == "SagDuvar"){
            top.velocity = new Vector2 (-yatayHiz+2f,top.velocity.y);
        }

        if(temas.gameObject.tag == "UstDuvar")
        {
            top.velocity = new Vector2(top.velocity.x, -dikeyHiz+1f);
        }

        if(temas.gameObject.tag== "Bitis"){

            m = 1;
            if (hak == 1)
            {
                hakyazi.text = "Hak:" + 0;
                kazandikyazisi.text = "Maalesef Kaybettiniz\n Puaniniz:" + kazandik.skor + "\nKirdiginiz Blok:" + kazandik.kirilanBlok + "\n\nTekrar oynamak icin a tusuna basin";
                Time.timeScale = 0;
                hak = 3;
                Destroy(puanyazi.gameObject);
                Destroy(topobje.gameObject);
                Destroy(playerobje.gameObject); 
                Destroy(bloklar.gameObject);
            }
        }
    }
}