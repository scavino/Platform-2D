﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movinLeft = true;
    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(movinLeft==true)
            {
                transform.eulerAngles = new Vector3(0,180, 0);
                movinLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movinLeft = true;
            }
        }
    }

}
