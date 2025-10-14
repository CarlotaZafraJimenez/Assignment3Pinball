using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBank : MonoBehaviour
{
    public int points;
    public GameObject[] targets;
    private bool waitingToReset = false;
    public float resetTime = 0.1f;
    private void Update()
    { 
        if (waitingToReset)
        {
            return;
        }
        bool allDown = true;
        foreach (GameObject target in targets)
        {
            if (target.activeInHierarchy)
            {
               allDown = false;
                break;
            }
        }
        if (allDown)
        {
            waitingToReset = true;
            ScoreManager.AddScore(points);
            Invoke("ResetTargets", resetTime);
        }
    }
    private void ResetTargets()
    {
        foreach (GameObject target in targets)
        {
            target.SetActive(true);
        }
        waitingToReset = false;
    }
}
