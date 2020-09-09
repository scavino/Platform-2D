using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector2 offset;

    void Update()
    {
        //transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z); 
        // Camera follows the player with specified offset position
        transform.position = new Vector2(player.position.x + offset.x, offset.y);
    }   
}
