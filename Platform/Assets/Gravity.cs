﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed;

    public Transform spawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
       


    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        //if(Input.touchCount>0) // touchscreen
        {
            rb.gravityScale *= -1;
            if(rb.gravityScale<0)
            {
                transform.eulerAngles = new Vector3(-180, 0, 0);
            }
            if(rb.gravityScale>0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("KillZone") || col.transform.CompareTag("enemy"))
        {
            rb.transform.position = spawnPoint.position;

            //gameOverUI.SetActive(true);
            //Time.timeScale = 0f;

           
        }


    }
}
