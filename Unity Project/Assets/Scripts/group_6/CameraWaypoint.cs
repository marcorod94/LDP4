using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraWaypoint : MonoBehaviour
{
    public Vector3 cameraPosition;
    public CameraWaypoint nextWaypoint;

    void OnCollisionEnter(Collision collision)
    {
        if(nextWaypoint != null && collision.gameObject.GetComponent<Camera>() != null)
        {
            collision.gameObject.transform.position = transform.position;
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
