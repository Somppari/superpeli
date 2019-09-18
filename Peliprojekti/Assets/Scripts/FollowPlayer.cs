using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    Vector3 CameraPosition;    

    // Start is called before the first frame update
    void Start()
    {
        
                
    }

    // Update is called once per frame
    void Update()
    {
        CameraPosition = new Vector3(Player.transform.position.x, transform.position.y, -5.15f);
        transform.position = CameraPosition;
    }
}
