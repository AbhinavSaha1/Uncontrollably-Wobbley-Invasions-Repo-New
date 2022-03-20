using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchGuardActivator : MonoBehaviour
{
    GuardStateManager _guardStateManager;
    public bool isInActivationZone;
   
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInActivationZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInActivationZone = false;
        }
    }
}
