using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rb;
    public bool isPunching= false;
    public int punchForce;
    public Vector3 hand;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K) && isPunching == false)
        {
            animator.SetBool("Right hand grab", true);
            isPunching = true;
        }
        else if (Input.GetKeyDown(KeyCode.L) && isPunching == false)
        {
            animator.SetBool("Left hand  grab", true);
            isPunching = true;
        }
        if (Input.GetKeyUp(KeyCode.K) && isPunching== true)
        {
            animator.SetBool("Right hand grab", false);
            isPunching = false;
        }
        else if (Input.GetKeyUp(KeyCode.L) && isPunching == true)
        {
            animator.SetBool("Left hand  grab", false);
            isPunching = false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item" && isPunching == true)
        {
            other.GetComponent<Rigidbody>().AddRelativeForce(gameObject.transform.forward * punchForce);
            Debug.Log("Punch force applied");
        }
    }
}
