using UnityEngine;
public class CameraController : MonoBehaviour
{
    [Header("Camera Settings")]
    public static CameraController instance;
    public float sensitivity = 5.0f, maxDistance = 7.65f, curDistance, scrollAdjustRate = 0.35f, minDistance = 1.0f, smoothSpeed = 10f;
    public Transform player;
    public bool cameraCanMove = true;

    [Header("Vertical Angle Lock")]
    public float upperLookAngle = 65, lowerLookAngle = 89.999f;
    private float rotationX = 0f;
    void Awake()
    {
        curDistance = maxDistance;
        if(instance == null)
        {
            instance = this;
        }
        else
        { if(instance != this)
            Destroy(gameObject);
        }
    } 
    void LateUpdate()
    {
        if(cameraCanMove)
        {
        float scrollDir = Input.mouseScrollDelta.y;
        if (scrollDir != 0)
        {
            {
                if (scrollDir < 0)
                {
                    if (curDistance <= maxDistance)
                    {curDistance += scrollAdjustRate;}
                }
                else 
                {
                    if (curDistance >= minDistance + scrollAdjustRate)
                    {curDistance -= scrollAdjustRate;}
                }
            }
        }
        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        //
        rotationX -= vertical;
        rotationX = Mathf.Clamp(rotationX, upperLookAngle, lowerLookAngle);
        //    
        player.Rotate(Vector3.up * horizontal);
        Quaternion rotation = Quaternion.Euler(rotationX, player.eulerAngles.y, 0);

        Vector3 desiredPosition = player.position - rotation * Vector3.forward * curDistance;

        if (Physics.Linecast(player.position, desiredPosition, out RaycastHit hit))
        {
            float adjustedDistance = Mathf.Clamp(hit.distance * 0.9f, minDistance, curDistance);
            desiredPosition = player.position - rotation * Vector3.forward * adjustedDistance;
        }
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);

        transform.LookAt(player.position + Vector3.up * 1.5f); }
    }
}
