using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maviyedek : MonoBehaviour
{
    public int BlokSaglęk;
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
            BlokSaglęk--;
            Debug.Log("can 1 azaldi");
        }
        if (BlokSaglęk == 0)
        {
            Destroy(this.gameObject);
        }
        if (BlokSaglęk == 1)
        {
            ressamm.material = renkk;
            can.text = "1";
        }

    }
}
