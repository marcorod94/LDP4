using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    private void LateUpdate()
    {
        if (target != null) transform.LookAt(target);
    }
}
