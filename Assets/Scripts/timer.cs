using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    float timerTime = 1;
    float timerReset = 1;
    public Rigidbody2D rb;


    private void Start()
    {
        rb.mass = rb.mass + timerTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerTime -= Time.deltaTime;
        if (timerTime >= 0f)
        {
           
            timerTime = timerReset;
        }
    }
}
