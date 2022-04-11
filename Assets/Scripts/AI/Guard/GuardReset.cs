using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardReset : MonoBehaviour
{
    private GameObject[] partsArray;
    private Vector3[] positionsArray;
    private Quaternion[] rotationsArray;
    private Transform coreTransform;

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
            partsArray[indexCount] = child.gameObject;
            positionsArray[indexCount] = child.localPosition;
            rotationsArray[indexCount] = child.localRotation;
            indexCount++;
        }

        for(int indexCounter = 0; indexCounter<partsArray.Length; indexCounter++)
        {
            if(partsArray[indexCounter].name=="Hips")
            {
                coreTransform = partsArray[indexCounter].transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetChildren()
    {
        gameObject.transform.position = coreTransform.position;
        gameObject.transform.rotation = coreTransform.rotation;

        for(int indexCounter = 0; indexCounter<partsArray.Length; indexCounter++)
        {
            partsArray[indexCounter].transform.localPosition = positionsArray[indexCounter];
            partsArray[indexCounter].transform.localRotation = rotationsArray[indexCounter];
            partsArray[indexCounter].GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}
