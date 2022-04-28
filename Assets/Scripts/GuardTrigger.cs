using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardTrigger : MonoBehaviour
{
    //test3
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            Debug.Log("Something has entered the guard trigger :" + other.gameObject.name);
        }
    }
}
