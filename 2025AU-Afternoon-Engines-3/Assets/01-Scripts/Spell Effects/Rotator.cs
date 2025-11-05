using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float XRotationVelocity;
    public float YRotationVelocity;
    public float ZRotationVelocity;
    
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(XRotationVelocity, YRotationVelocity, ZRotationVelocity) * Time.deltaTime);
    }
}
