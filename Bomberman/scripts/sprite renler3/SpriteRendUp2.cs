using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteRendUp2 : MonoBehaviour
{
    public static SpriteRenderer spriteRen;
    public static Animator anim;

    private void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
}