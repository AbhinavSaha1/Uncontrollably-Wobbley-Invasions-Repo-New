using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCracker : MonoBehaviour
{
    public float Delay = 1f;
    public float ExplosionRadius = 5f;
    public float ExplosionForce = 700f;
    float _countdown;
    bool _hasExploded;
    public bool shouldStartCountDown = false;
    public GameObject ExplosionEffect;
    void Start()
    {
        _countdown = Delay;
    }

    void Update()
    {
        if(shouldStartCountDown)
        {
            _countdown -= Time.deltaTime;

            if (_countdown <= 0 && !_hasExploded)
            {
                Explode();
                _hasExploded = true;
            }
        }
    }

    private void Explode()
    {
       GameObject explosionEfx = Instantiate(ExplosionEffect, transform.position, transform.rotation);

        Collider[] collidersToStun = Physics.OverlapSphere(transform.position, ExplosionRadius);

        foreach (Collider nearbyObject in collidersToStun)
        {
            FootballerStateManager footballer = nearbyObject.GetComponent<FootballerStateManager>();
            GuardStateManager guard = nearbyObject.GetComponent<GuardStateManager>();
            if (footballer != null)
            {
                footballer.SwitchState(footballer.StunState);
            }
            if(guard!= null)
            {
                guard.SwitchState(guard.StunState);
            }
        }

        Collider[] collidersToAddForce = Physics.OverlapSphere(transform.position, ExplosionRadius);

        foreach (Collider nearbyObject in collidersToAddForce)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(ExplosionForce, transform.position, ExplosionRadius);
            }
        }
        Destroy(gameObject);
        Destroy(explosionEfx, 3);
    }
}
