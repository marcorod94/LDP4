using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] GameObject cameraToSwitch;
    GameObject mainCamera;

    void Start()
    {
        mainCamera = Camera.main.gameObject;
    }

    void OnTriggerEnter()
    {
        cameraToSwitch.SetActive(true);
        mainCamera.SetActive(false);
    }

    void OnTriggerExit()
    {
        mainCamera.SetActive(true);
        cameraToSwitch.SetActive(false);
    }
}
