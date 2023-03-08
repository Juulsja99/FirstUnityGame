using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 10, 0, ForceMode.Acceleration);
        }

    }
}
