using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationforward : MonoBehaviour
{
    public float Rotazione = 100.0f; //decidi tu la forza

    // Start is called before the first frame update
   // void Start()
   // {
        
   // }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * Rotazione * Time.deltaTime);//vector3.decidi tu
    }
}
