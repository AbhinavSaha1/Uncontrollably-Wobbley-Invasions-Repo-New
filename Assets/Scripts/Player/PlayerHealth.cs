using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    bool stunPlayerTest;
    public int maxHealth = 100;
    public int currentHealth;
    public bool playerStunned;
    [SerializeField]
    float playerStunTime;
    [SerializeField]
    PlayerController _playerController;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //TakeDamage(100);
    }

    void Update()
    {
        if(stunPlayerTest)
        {
            TakeDamage(100);
            stunPlayerTest = false;
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("Stun the player");
            //STUN the player
            StartCoroutine(PlayerStunRoutine());
        }
    }
    IEnumerator PlayerStunRoutine()
    {
        _playerController.enabled = false;
        playerStunned = true;
        yield return new WaitForSeconds(playerStunTime);
        _playerController.enabled = true;
        playerStunned = false;
        currentHealth = 100;
        healthBar.SetHealth(currentHealth);
    }
}
