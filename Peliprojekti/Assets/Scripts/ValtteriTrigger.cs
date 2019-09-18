using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValtteriTrigger : MonoBehaviour
{

    public GameObject dialog;
    public Transform playerPos;
    bool triggerEntered = false;
    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("valtteriObject"))
        {
            clone.transform.position = new Vector2(playerPos.position.x, 3f);
        }            
    }

    void OnTriggerEnter2D()
    {
        if (!GameObject.FindGameObjectWithTag("valtteriObject"))
        {
            Debug.Log("Trigger entered");
            clone = Instantiate(dialog);
            triggerEntered = false;
            
        }

    }

    void OnTriggerExit2D()
    {
        if (GameObject.FindGameObjectWithTag("valtteriObject"))
        {
            Debug.Log("Trigger exited");
            Destroy(clone, 1);
            triggerEntered = true;
        }        
    }
}
