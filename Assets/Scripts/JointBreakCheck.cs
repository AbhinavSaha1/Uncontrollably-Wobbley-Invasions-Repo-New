using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointBreakCheck : MonoBehaviour
{
    public bool hasJointBroken;

    public void OnJointBreak(float breakForce)
    {
        hasJointBroken = true;
        Debug.Log("Grab released");
    }
}
