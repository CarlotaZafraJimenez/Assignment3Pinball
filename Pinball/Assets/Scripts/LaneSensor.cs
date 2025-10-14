using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSensor : MonoBehaviour
{
    public int points = 25;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
        }
    }
}
