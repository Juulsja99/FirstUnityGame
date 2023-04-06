using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class counterUI : MonoBehaviour
{

    private TMP_Text scoreField;
    private int score = 0;

    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        score = 0;
        scoreField.text = "Bounce counter " + score;
    }

   
    void Update()
    {
        
    }

    public void AddScore(int add)
    {
        score += add;
        scoreField.text = "Bounce counter " + score;

    }
}
