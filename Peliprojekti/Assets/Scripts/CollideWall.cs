using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWall : MonoBehaviour
{
    float groundPos = -5.953937f;
    float leftCorner = -18.5f;
    public Transform player;
    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z);
    }




    void OnCollisionEnter2D()
    {
        Debug.Log("Collided on wall!");

        if(player.transform.position.x < leftCorner)
        {
            player.transform.position = new Vector2(-7.0f, groundPos);
        }


        
    }



}
