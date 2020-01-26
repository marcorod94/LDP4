using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Vector3 destination;
    

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Teleport");
        collider.gameObject.transform.position = destination;
    }
}
