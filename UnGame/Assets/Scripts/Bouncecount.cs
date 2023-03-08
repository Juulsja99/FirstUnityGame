using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncecount : MonoBehaviour
{
    public int counter = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        counter += 1;
        Debug.Log(collision.collider.name);
        Debug.Log(counter);
    }
}
