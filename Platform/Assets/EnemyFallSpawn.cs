using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFallSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject quadratorosso;
    public float spawnRate;
    public float nextSpawn;
    int whatToSpwan;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate(quadratorosso, new Vector3(Random.Range(-10,10), Random.Range(-15,15), 0), Quaternion.identity);

        if (Time.time > nextSpawn)
        {
            whatToSpwan = Random.Range(1, 2);

            switch (whatToSpwan)
            {
                case 1:
                    Instantiate(quadratorosso, new Vector3(Random.Range(-10, 10), Random.Range(0,12), 0), Quaternion.identity);
                    //Instantiate(quadratorosso, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;
            
        }
    }

   
}


