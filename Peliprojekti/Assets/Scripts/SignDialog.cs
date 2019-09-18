using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignDialog : MonoBehaviour
{

    public GameObject player;
    public GameObject dialog;
    bool triggerEntered = false;
    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        triggerEntered = true;

        if(triggerEntered)
        {
            Debug.Log("Trigger entered");
            clone = Instantiate(dialog);
            triggerEntered = false;
        }
        
    }

    void OnTriggerExit2D()
    {

        Debug.Log("Trigger entered");
        Destroy(clone, 0.2f);
    }
    

}
