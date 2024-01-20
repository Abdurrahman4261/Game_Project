using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class Duvar_Carpisma : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D duvar) {
        if(duvar.gameObject.tag=="bomba"||duvar.gameObject.tag=="ates"||duvar.gameObject.tag=="hiz"
           ||duvar.gameObject.tag=="kick"||duvar.gameObject.tag=="unknown"||duvar.gameObject.tag=="fire_down"){
            Debug.Log("ates"+duvar.gameObject.tag);
            Destroy(duvar.gameObject); 
        }  
    }
}
 