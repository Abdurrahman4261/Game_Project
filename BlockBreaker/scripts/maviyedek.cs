using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maviyedek : MonoBehaviour
{
    public int BlokSagl�k;
    private MeshRenderer ressamm;
    public Material renkk;
    public TextMesh can;

    void Start()
    {
        ressamm = GetComponent<MeshRenderer>();
        can = GetComponent<TextMesh>();
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Top")
        {
            BlokSagl�k--;
            Debug.Log("can 1 azaldi");
        }
        if (BlokSagl�k == 0)
        {
            Destroy(this.gameObject);
        }
        if (BlokSagl�k == 1)
        {
            ressamm.material = renkk;
            can.text = "1";
        }

    }
}
