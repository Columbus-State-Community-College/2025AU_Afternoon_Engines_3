using UnityEngine;
public class CameraController : MonoBehaviour
{
    [Header("Camera Settings")]
    public float sensitivity = 5.0f;
    public float distance = 5.0f;               // how far the camera normally stays from the player
    public float minDistance = 1.0f;            // how close it can move to avoid clipping
    public float smoothSpeed = 10f;             // smooth interpolation
    public Transform player;

    [Header("Vertical Angle Lock")]
    public float upperLookAngle = 65;
    public float lowerLookAngle = 89.999f;
    private float rotationX = 0f;
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        //
        rotationX -= vertical;
        rotationX = Mathf.Clamp(rotationX, upperLookAngle, lowerLookAngle);
        //    
        player.Rotate(Vector3.up * horizontal);
        Quaternion rotation = Quaternion.Euler(rotationX, player.eulerAngles.y, 0);

        Vector3 desiredPosition = player.position - rotation * Vector3.forward * distance;

        if (Physics.Linecast(player.position, desiredPosition, out RaycastHit hit))
        {
            float adjustedDistance = Mathf.Clamp(hit.distance * 0.9f, minDistance, distance);
            desiredPosition = player.position - rotation * Vector3.forward * adjustedDistance;
        }
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);

        transform.LookAt(player.position + Vector3.up * 1.5f); 
    }
}
