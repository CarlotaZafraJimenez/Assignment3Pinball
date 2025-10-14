using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public float bounceForce = 1.0f;
    public int points = 100;

    private AudioSource audioSrc;
    private void Start()
    {
        audioSrc = GetComponentInChildren<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
  {
    if (collision.transform.CompareTag("PlayerBall"))
        {
            audioSrc.Play();
            Vector3 myCenter = transform.position;
            Vector3 contactPoint = collision.GetContact(0).point;

            myCenter.y = contactPoint.y;
            Vector3 forceVector = contactPoint - myCenter;

            Rigidbody rb = collision.rigidbody;
            rb.AddForce(forceVector * bounceForce, ForceMode.Impulse);
            ScoreManager.AddScore(points);
        }
  }
}
