using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schiet : MonoBehaviour
{

    public GameObject prefab;
    public ParticleSystem schiet;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            schiet.Play();
            GameObject ob = Instantiate(prefab);
            ob.transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.5f);
            ob.transform.rotation = transform.rotation;
            Destroy(ob, 3f);
        }

    }
}
