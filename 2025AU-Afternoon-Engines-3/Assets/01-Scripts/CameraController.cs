using UnityEngine;
public class CameraController : MonoBehaviour
{
    [Header("First Person POV Camera Settings")]
    [Tooltip("Mouse sensitivity for rotating, lower if rotating is too fast")]
    public float sensitivity = 5.0f;
    private float rotation = 0f;
    [Tooltip("Place Player object here for horizontal rotation")]
    public Transform player;
    void Update()
    {

        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        rotation -= vertical; 
        rotation = Mathf.Clamp(rotation, -90f, 90f);  
        transform.localEulerAngles = Vector3.right * rotation; 
        player.Rotate(Vector3.up * horizontal);

    }
}
