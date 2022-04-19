using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public FootballerStateManager footballer;
    public bool canDamage;

    void Start()
    {
        currentHealth = maxHealth;
        //footballer = FindObjectOfType<FootballerStateManager>();
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
            footballer.SwitchState(footballer.StunState);
            currentHealth = 100;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Rigidbody item = other.GetComponent<Rigidbody>();
            Debug.Log("Something has entered the footballer trigger :" + other.gameObject.name + "  " + item.velocity.magnitude);
            if (item.velocity.magnitude >= 10 && item.velocity.magnitude <= 12)
            {
                TakeDamage(15);
            }
            if (item.velocity.magnitude >= 12)
            {
                TakeDamage(30);
            }
        }
    }
}
