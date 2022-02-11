using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballreturn : MonoBehaviour
{
    [SerializeField]
    KeyCode keyResetBall;
    // Start is called before the first frame update
    [SerializeField]
     Vector3 v3Force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
                if(Input.GetKey(keyResetBall))
            GetComponent<Rigidbody>().position = new Vector3 (-1.02f,0.974f,-0.673f);
    }
}
