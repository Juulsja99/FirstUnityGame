using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncecount : MonoBehaviour
{
    private Rigidbody rb;
    public int counter = 0;
    private bool OnFloor = false;
    private counterUI scoreScript;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        scoreScript = FindObjectOfType<counterUI>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            OnFloor = true;
            counter += 1;
            Debug.Log("Bounce");
            scoreScript.AddScore(+1);

        }

          
       
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            OnFloor = false;
        }

    }


}
