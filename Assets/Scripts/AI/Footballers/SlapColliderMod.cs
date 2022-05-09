using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapColliderMod : MonoBehaviour
{
    public Collider SlapCollider;

    public void SlapColliderEnable()
    {
        SlapCollider.enabled = true;
    }
    public void SlapColliderDisable()
    {
        SlapCollider.enabled = false;
    }
}
