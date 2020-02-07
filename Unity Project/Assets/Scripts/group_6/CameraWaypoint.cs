using Assets.Elenesski.Camera.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.Utility;

public class CameraWaypoint : MonoBehaviour
{
    public Vector3 cameraPosition;
    public CameraWaypoint nextWaypoint;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<ThirdPersonCharacter>() != null)
        {
            GameObject cam = GameObject.FindWithTag("MainCamera");
            cam.transform.LookAt(collision.transform);
            cam.GetComponent<FollowTarget>().offset = cameraPosition - collision.gameObject.transform.position;
            cam.GetComponent<GenericMoveCamera>().enabled = false;
            cam.GetComponent<LookAt>().enabled = true;
        }
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(CameraWaypoint))]
    class CameraWaypointEditor : Editor
    {
        protected virtual void OnSceneGUI()
        {
            CameraWaypoint waypoint = (CameraWaypoint)target;

            Handles.color = Color.white;
            Handles.DrawWireCube(waypoint.transform.position, Vector3.one);

            Handles.color = Color.red;
            Handles.DrawWireCube(waypoint.cameraPosition, Vector3.one);

            Handles.color = Color.yellow;
            Handles.DrawLine(waypoint.transform.position, waypoint.cameraPosition);


            if (waypoint.nextWaypoint != null)
            {
                Handles.DrawLine(waypoint.transform.position, waypoint.nextWaypoint.transform.position);
                Handles.DrawLine(waypoint.cameraPosition, waypoint.nextWaypoint.cameraPosition);
            }
        }
    }
#endif
}
