using System.Collections;
using UnityEngine;
public class ColliderScript : MonoBehaviour
{
    // These Variables are basically the key part to how this whole thing works, so I'll do my best to explain.
    [Header("Dictated Collision Methods")]
    public bool FlagActionOnCollision = false; //Toggle once after single touch and do not turn off.
    public bool FlagActiveWhileTouching = false; //Toggle only while touching, and turn off when not.
    [Header("Flag either active depending on context, leave off for both.")]
    public bool triggerOnlyOnPlayer;
    public bool triggerNeverOnPlayer;

    [Header("Affected GameObject to move.")]
    public GameObject AttachedObject;

    [Header("Dictated Effect Types")]
    public bool moveObject;
    [Header("Move Object Modifier/Ignore otherwise")]
    [Header("Note, if using WhileTouching, set values very low")]
    public float moveObjectDistanceX;
    public float moveObjectDistanceY;
    public float moveObjectDistanceZ;
    [Header("Misc/Hidden")]

     private bool objectMoved;
    private bool isActive = false;
    private bool keepActive = false;

    void Update()
    {
        if (AttachedObject == null) 
        {
            Debug.Log("error null update");
            return; 
        }
        if (isActive || keepActive)
        {

            if (moveObject)
            {
                Vector3 offset = new Vector3(moveObjectDistanceX, moveObjectDistanceY, moveObjectDistanceZ);
                AttachedObject.transform.position += offset;
                objectMoved = true;
                isActive = false;
            }
        }
        if (!keepActive && FlagActiveWhileTouching)
        {
            isActive = false;
            if (moveObject && objectMoved)
            {
                Vector3 offset = new Vector3(moveObjectDistanceX, moveObjectDistanceY, moveObjectDistanceZ);
                AttachedObject.transform.position -= offset;
                objectMoved = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if ((AttachedObject == null)|| (triggerOnlyOnPlayer && !other.gameObject.CompareTag("Player")) || (triggerNeverOnPlayer && other.gameObject.CompareTag("Player")))
        {
            return;
        }
        if (FlagActionOnCollision)
        {
            isActive = true;
        }

        if (FlagActiveWhileTouching)
        {
            keepActive = true;
            isActive = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
    if ((AttachedObject == null)|| (triggerOnlyOnPlayer && !other.gameObject.CompareTag("Player")) || (triggerNeverOnPlayer && other.gameObject.CompareTag("Player")))
        {
            return;
        }


        if (FlagActiveWhileTouching)
        {
            keepActive = false;
        }

    }
}
