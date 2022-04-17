using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Puching the player");
            PlayerHealth playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
            playerHealth.TakeDamage(20);
        }
    }
}
