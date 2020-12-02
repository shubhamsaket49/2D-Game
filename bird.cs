﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    public float upForce = 100f;
    private bool Isdead = false;
    private Rigidbody2D rb2d;
    private Animator anm;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        anm = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Isdead == false)
        {
            if(Input.GetMouseButtonDown (0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anm.SetTrigger("Flap");
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    	rb2d.velocity = Vector2.zero;
        Isdead = true;
        anm.SetTrigger("Die");
        GameControl.intance.BirdDied();
    }
}
