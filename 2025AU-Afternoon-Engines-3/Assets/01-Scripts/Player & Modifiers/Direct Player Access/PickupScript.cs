using UnityEngine;

public class PickupScript : MonoBehaviour
{
    [Header("Holding Settings")]
    public Transform holdPoint;        
    public float holdDistance = 1.2f;
    public float pickupRange = 2.5f;
    public float moveSpeed = 10f;
    public KeyCode pickupKey = KeyCode.E; 
    private GameObject heldObject;
    private Rigidbody heldRb;

    void Update()
    {
        if (Input.GetKeyDown(pickupKey))
        {
            if (heldObject == null)
            {TryPickup();}
            else
            {DropObject();}
        }
        if (heldObject != null)
        {MoveHeldObject();}
    }

    void TryPickup()
    {
        Ray ray = new Ray(transform.position + Vector3.up * -0.4f, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * pickupRange, Color.cyan);
        if (Physics.Raycast(ray, out RaycastHit hit, pickupRange))
        {
            GameObject target = hit.collider.gameObject;
            if (target.CompareTag("Moveable") || target.CompareTag("Summoned"))
            {PickupObject(target);}
        }
    }

    void PickupObject(GameObject obj)
    {
        heldObject = obj;
        heldRb = obj.GetComponent<Rigidbody>();

        if (heldRb != null)
        {
            heldRb.useGravity = false;
            heldRb.linearVelocity = Vector3.zero;
            heldRb.angularVelocity = Vector3.zero;
        }

        if (holdPoint == null)
        {
            holdPoint = new GameObject("HoldPoint").transform;
            holdPoint.SetParent(transform);
            holdPoint.localPosition = new Vector3(0f, 0.8f, holdDistance);
        }

        heldObject.transform.SetParent(holdPoint);
    }

    void MoveHeldObject()
    {
        Vector3 targetPos = holdPoint.position;
        heldObject.transform.position = Vector3.Lerp(heldObject.transform.position, targetPos, Time.deltaTime * moveSpeed);
    }

    void DropObject()
    {
        if (heldObject == null) return;

        if (heldRb != null)
        {heldRb.useGravity = true;}

        heldObject.transform.SetParent(null);
        heldObject = null;
        heldRb = null;
    }
}