using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
   {
    if (other.CompareTag("PlayerBall"))
        {
            Destroy (other.gameObject);
            manager.EndBall();
        }
    }
}
