﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Switch")
        {

            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.gravityScale *= -1;
            }
        }
    }
}
