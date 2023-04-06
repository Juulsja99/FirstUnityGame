using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public float threshold;


    
    void FixedUpdate()
    {
       if (transform.position.y < threshold) 
        {
            transform.position = new Vector3(-18.69f, 0.47f, -11.280f);
        }
    }
}
