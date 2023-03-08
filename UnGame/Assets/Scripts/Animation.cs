using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator m_Animator;
    private Animator ani;


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {

            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("WalkR");


        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
        }

        else
        {
            ani.SetTrigger("Idle");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Walk");
        }
    }
}    
