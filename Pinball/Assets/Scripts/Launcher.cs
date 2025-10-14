using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float launchForce = 1.0f;
    public float fullForceDuration = 0.8f;

    private float secondsHeld = 0;
    private Rigidbody rb;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            secondsHeld += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
           float timePCT = secondsHeld / fullForceDuration;
            if (timePCT > 1) 
            {
                timePCT = 1;
            }

            if (rb != null)
            {
                rb.AddForce(transform.up * launchForce * timePCT); 
            }
        }   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            rb = collision.rigidbody;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
            rb = null;
    }
}
