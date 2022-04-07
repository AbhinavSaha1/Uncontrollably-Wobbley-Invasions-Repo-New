using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something has entered the guard trigger");
    }
}
