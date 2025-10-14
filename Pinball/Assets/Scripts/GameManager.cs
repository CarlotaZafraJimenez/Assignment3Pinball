using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public int lives = 3;
    public GameObject ballPrefab;
    public Transform ballStart;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    public void EndBall()
    {
        lives--;
        if (lives == 0)
        { 
        gameOverPanel.SetActive(true);
        }
        else
        {
            Instantiate (ballPrefab, ballStart.position, Quaternion.identity);
        }
    }
}
