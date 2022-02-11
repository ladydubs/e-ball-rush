using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dosomething : MonoBehaviour
{

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;
    
    [SerializeField]
    Vector3 v3Force;
    // Start is called before the first frame update
    void Start()
    {


    }

    // FixedUpdate is called one hundred times per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        
        if(Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;


        
    }
}
