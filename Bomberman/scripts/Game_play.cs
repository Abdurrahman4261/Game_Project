using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_play : MonoBehaviour
{
    public GameObject p1;
    
    // [SerializeField] private Vector3 newGravity;
 
    // Start is called before the first frame update
    void Start()
    {
        //Physics.gravity = newGravity; 
        Vector2 pos = new Vector2(-15,8);
        //p1=GameObject.Find("p1") as GameObject;
        Instantiate(p1,pos,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
