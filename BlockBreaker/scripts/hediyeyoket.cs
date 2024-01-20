using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hediyeyoket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D x)
    {
        if (x.gameObject.name == "playerorta"||Time.timeScale==0 || x.gameObject.tag== "Bitis"|| x.gameObject.name == "playersol" || x.gameObject.name == "playersag")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
