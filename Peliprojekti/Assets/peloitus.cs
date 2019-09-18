using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peloitus : MonoBehaviour
{
    public float jumpHeight = 10f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 10f)
        {
            if (transform.position.y <= -3.55) 
            {
                float movespeed = 1.0f;
                movespeed++;
                transform.position = new Vector2(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
            } 
        }
    }
}
