using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHit : MonoBehaviour
{

    public string targetTag;
    private AudioSource sound;
    public ParticleSystem schiet;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            schiet.Play();
            Debug.Log("Hit");
            Destroy(coll.gameObject, 0.1f);
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            schiet.Play();
            Debug.Log("Hit");
            Destroy(coll.gameObject, 0.1f);
            
        }
    }
}
