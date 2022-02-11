using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballstop : MonoBehaviour
{
    [SerializeField]
    KeyCode keyStopBall;
    
    [SerializeField]
     Vector3 v3Force;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {       if(Input.GetKey(keyStopBall)){

            //GetComponent<Rigidbody>().velocity.magnitude = 0;
            GetComponent<Rigidbody>().velocity =v3Force;
    }    
    }
}
