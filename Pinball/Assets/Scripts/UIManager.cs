using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    private GameManager manager;
    void Start()
    {
        manager = FindObjectOfType<GameManager>();    
    }
    private void Update()
    {
        livesText.text = "Balls: " + manager.lives.ToString();
    }
}
