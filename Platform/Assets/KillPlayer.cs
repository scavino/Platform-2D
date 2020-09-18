using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public Transform spawnPoint;
   

   
    void OnCollisionEnter2D(Collision2D col)
    {
       
        if(col.transform.CompareTag("Player"))
        {   
            // col.transform.position = spawnPoint.position;
            SceneManager.LoadScene("GameOver");

            //ScoreScript.scoreValue=0;
        }
     
    }
}
