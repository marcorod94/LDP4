using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Elenesski.Camera.Utilities;

public class TriggerCameraChange : MonoBehaviour
{

    public GenericMoveCamera camera;
    public GameObject alternativeLookAt;

     [SerializeField]
     private float offset = 10.0f;


    private void OnTriggerEnter(Collider other)
    {
        camera.LookAtTarget = alternativeLookAt;
        
    }

}
