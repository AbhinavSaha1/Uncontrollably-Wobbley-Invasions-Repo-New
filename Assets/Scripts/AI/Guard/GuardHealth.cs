using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    GuardStateManager guard;
    public bool canDamage;

    void Start()
    {
        currentHealth = maxHealth;
        guard = FindObjectOfType<GuardStateManager>();
    }

    void Update()
    {
       
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("Guard Dead: Changing to stun state");
            guard.SwitchState(guard.StunState);
            currentHealth = 100;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item") && canDamage)
        {
            Rigidbody item = other.GetComponent<Rigidbody>();
            Debug.Log("Something has entered the guard trigger :" + other.gameObject.name + "  " + item.velocity.magnitude);
            if(item.velocity.magnitude >= 10 && item.velocity.magnitude <= 12)
            {
                TakeDamage(15);
            }
            if(item.velocity.magnitude >= 12)
            {
                TakeDamage(30);
            }
        }
    }
}
