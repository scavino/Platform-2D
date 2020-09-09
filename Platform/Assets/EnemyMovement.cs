using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void FixedUpdate()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);


       
    }
}
