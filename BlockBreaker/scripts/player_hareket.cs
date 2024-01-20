using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_hareket : MonoBehaviour
{
    public float hiz;
    public GameObject playerlar;
    public static int m = 0,x=0;
    public TextMesh hizyazi;
    public Rigidbody2D top;

    private Vector2 temp;
    private void Start()
    {       
        //hizyazi.text = "hiz:" + top.velocity;
    }
    void Update()
    {
        hizyazi.text = "hiz:" + top.velocity;
        

        if (Input.GetKey(KeyCode.A))
        {  
            playerlar.transform.Translate((-hiz) * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerlar.transform.Translate((hiz) * Time.deltaTime, 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D a)
    {
        if (a.gameObject.tag == "boyut")
        {
            Debug.Log("temas");
            playerlar.transform.localScale = new Vector2(playerlar.transform.localScale.x+0.3f, playerlar.transform.localScale.y);

        }

        if (a.gameObject.tag == "kücük")
        {
            if(playerlar.transform.localScale.x > 0.3f)
            {
                Debug.Log("kücük");
                playerlar.transform.localScale = new Vector2(playerlar.transform.localScale.x - 0.3f, playerlar.transform.localScale.y);
            }

        }

        if (a.gameObject.tag == "hiz")
        {
            top.velocity = new Vector2(top.velocity.x, top.velocity.y+1f); 
            x = 2;
        }

        if (a.gameObject.tag == "yavas")
        {

            top.velocity = new Vector2(top.velocity.x, top.velocity.y -1f);
            x = 1;
        }

        if (a.gameObject.tag == "hak")
        {
            m =3;
        }
    }
}
