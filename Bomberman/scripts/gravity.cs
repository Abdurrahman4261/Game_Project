using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    
    // [SerializeField] private Vector3 newGravity;
    void Start()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

}
