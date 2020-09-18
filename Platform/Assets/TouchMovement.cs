using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;

    private Rigidbody2D playerbody;
    private float ScreenWidth;
   

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        playerbody = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;

        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //playerbody.velocity = new Vector2(speed, playerbody.velocity.y);

                RunPLayer(1.0f);
                //transform.eulerAngles = new Vector3(0, 0, 0);
            }
           
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //playerbody.velocity = new Vector2(speed*-1, playerbody.velocity.y);
                RunPLayer(-1.0f);
               

            }
        }
    }

    //per farlo funzionare con tastiera
    void FixedUpdate()
    {
#if UNITY_EDITOR
        RunPLayer(Input.GetAxis("Horizontal"));
#endif
    }
    private void RunPLayer(float horizontalInput)
    {
        //playerbody.AddForce(new Vector2(horizontalInput * speed * Time.deltaTime, 0));
        playerbody.velocity = new Vector2(horizontalInput * speed, playerbody.velocity.y);
        if (horizontalInput < 0)
        {
            player.transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (horizontalInput > 0)
        {
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //playerbody.= new Vector2(horizontalInput * speed * Time.deltaTime, 0);


    }

    //float directionX;
    //Rigidbody2D rb;


    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();    
    //}

    //void Update()
    //{

    //    directionX = CrossPlatformInputManager.GetAxis("Horizontal");
    //    rb.velocity = new Vector2(directionX * 10, 0);

    //    if (directionX < 0)
    //    {
    //        transform.eulerAngles = new Vector3(0, 180, 0); // rotazione player da destra a sinistra
    //    }

    //    if (directionX > 0)
    //    {
    //        transform.eulerAngles = new Vector3(0, 0, 0); // rotazione player da sinistra a destra
    //    }

    //}


}
