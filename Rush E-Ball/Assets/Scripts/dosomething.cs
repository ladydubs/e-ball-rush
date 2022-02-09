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
    KeyCode keyResetBall;


    [SerializeField]
    Vector3 v3Force;
    // Start is called before the first frame update
    void Start()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

foreach (var device in inputDevices)
{
    Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.characteristics.ToString()));
}
    }

    // FixedUpdate is called one hundred times per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        
        if(Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;

        if(Input.GetKey(keyResetBall))
            GetComponent<Rigidbody>().position = new Vector3 (-1.02f,0.974f,-0.673f);
        
    }
}
