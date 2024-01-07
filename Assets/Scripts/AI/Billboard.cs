using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Cache the main camera for performance
    }

    void LateUpdate()
    {
        Vector3 cameraDirection = transform.position - mainCamera.transform.position;
        cameraDirection.x = 0; // Remove rotation on X-axis
        cameraDirection.z = 0; // Remove rotation on Z-axis
        transform.LookAt(mainCamera.transform.position - cameraDirection);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0); // Maintain upright orientation
    }
}
