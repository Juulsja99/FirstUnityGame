using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject pickup;
    private AudioSource source;
    private Renderer r;
    private ParticleSystem ps;
    private keepScore scoreScript;

    void Start()
    {
        source = GetComponent<AudioSource>();
        r = GetComponent<Renderer>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        scoreScript = FindObjectOfType<keepScore>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            //GameObject.Destroy(gameObject, 0.5f);
            source.Play();
            ps.Play();
            scoreScript.AddScore(5);

        }


    }
}
