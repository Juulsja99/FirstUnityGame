using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEn : MonoBehaviour
{ 
    private bool moveToLeft = true;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(moveToLeft == true)
        {
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime;
        }

        
        if(moveToLeft == false)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            
        }

        if(transform.position.x <= -5)
        {
            moveToLeft= false;
        }

        if (transform.position.x >= 5)
        {
            moveToLeft = true;
        }


    }
}
