using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyquadrato : MonoBehaviour
{
    public GameObject effect;
    // public int fallcube;

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Ground"))
        {
            // col.transform.position = spawnPoint.position;
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
           
            //ScoreScript.scoreValue = fallcube -1;
           
        }
    }
    
}
