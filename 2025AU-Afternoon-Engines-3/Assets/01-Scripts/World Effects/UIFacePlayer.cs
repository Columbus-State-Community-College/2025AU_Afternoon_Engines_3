using UnityEngine;

public class UIFacePlayer : MonoBehaviour
{
    void LateUpdate()
    {
        if (Camera.main)
            transform.LookAt(Camera.main.transform);
    }
}