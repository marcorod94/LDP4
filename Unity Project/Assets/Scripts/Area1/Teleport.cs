using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform destination;
    

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Teleport");
        Vector3 offset = collider.gameObject.transform.position - gameObject.transform.position;
        collider.gameObject.transform.position = destination.transform.position + offset;
    }
}
