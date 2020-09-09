using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathCollision : MonoBehaviour
{
    public Transform PlayerspawnPoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = PlayerspawnPoint.position;

            //ScoreScript.scoreValue=0;
        }
    }
}
