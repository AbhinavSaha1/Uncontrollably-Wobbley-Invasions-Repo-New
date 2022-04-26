using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardReset : MonoBehaviour
{
    private GameObject[] partsArray;
    private Vector3[] positionsArray;
    private Quaternion[] rotationsArray;
    private Transform coreTransform;
    public Transform hips;

    // Start is called before the first frame update
    void Start()
    {
        partsArray = new GameObject[transform.childCount];
        positionsArray = new Vector3[transform.childCount];
        rotationsArray = new Quaternion[transform.childCount];

        int indexCount = 0;
        foreach (Transform child in transform)
        {
            //child is your child transform
            Debug.Log("Child: " + child.gameObject.name);
            partsArray[indexCount] = child.gameObject;
            positionsArray[indexCount] = child.localPosition;
            rotationsArray[indexCount] = child.localRotation;
            indexCount++;
        }

        /*for(int indexCounter = 0; indexCounter<partsArray.Length; indexCounter++)
        {
            if(partsArray[indexCounter].name=="Hips")
            {
                Debug.Log("Parts" + partsArray[indexCounter].gameObject.name);
                
            }
        }*/

        coreTransform = hips;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetChildren()
    {
        Debug.Log("Reset childer called");
        gameObject.transform.position = coreTransform.position;
        gameObject.transform.rotation = coreTransform.rotation;

        for(int indexCounter = 0; indexCounter<partsArray.Length; indexCounter++)
        {
            Debug.Log("In reset children loop");
            partsArray[indexCounter].transform.localPosition = positionsArray[indexCounter];
            partsArray[indexCounter].transform.localRotation = rotationsArray[indexCounter];
            partsArray[indexCounter].GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}
