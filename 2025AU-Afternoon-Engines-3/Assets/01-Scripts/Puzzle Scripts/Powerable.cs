using UnityEngine;
using System.Collections;
public class Powerable : MonoBehaviour
{
    [Header("Toggle & Duration Settings (Puzzle Status)")]
    public bool powerStatus = false;
    public bool canTurnOff = false;
    public float powerDuration = 6f;
    public GameObject thisOffStatus;
    public GameObject thisOnStatus;
    private Coroutine powerRoutine;

    [Header("If the object should move while on, edit and allow below.")]
    public bool movesWhilePowered;
    public bool movesInstantly;
    public bool togglesObjectStatus;
    public GameObject affectedObject1;
    public GameObject affectedObject2;
    public GameObject affectedObject3;
    public Vector3 moveDirection = new Vector3(0f, 0f, 0f);
    public float moveSpeed = 2f;
    private Vector3 originalPosition;
    private void Start()
    {originalPosition = transform.position;}
    public void TogglePower()
    {
        if (powerStatus && !canTurnOff)
            {return;}

        powerStatus = !powerStatus;

        if (powerStatus)
        {OnPoweredOn();}
        else
        {OnPoweredOff();}

        if (powerStatus && canTurnOff)
        {
            if (powerRoutine != null)
                StopCoroutine(powerRoutine);
            powerRoutine = StartCoroutine(PowerDownAfterDelay());
        }
    }

    private IEnumerator PowerDownAfterDelay()
    {
        yield return new WaitForSeconds(powerDuration);
        powerStatus = false;
        OnPoweredOff();
    }

    void OnPoweredOn()
    {
        thisOnStatus.SetActive(true);
        thisOffStatus.SetActive(false);
        if (affectedObject1 != null)
        { ToggleActiveState(affectedObject1);}
        if (affectedObject2 != null)
        {ToggleActiveState(affectedObject2);}
        if (affectedObject3 != null)
        {ToggleActiveState(affectedObject2);}

    }

    void OnPoweredOff()
    {
        thisOnStatus.SetActive(false);
        thisOffStatus.SetActive(true);
        if (affectedObject1 != null)
        {ToggleActiveState(affectedObject1);}
        if (affectedObject2 != null)
        {ToggleActiveState(affectedObject2);}
        if (affectedObject3 != null)
        {ToggleActiveState(affectedObject2);}
    }

    public void ToggleActiveState(GameObject target)
    {
        if (togglesObjectStatus && target != null)
        {
            bool currentlyActive = target.activeSelf;
            target.SetActive(!currentlyActive);
        }
        if (movesWhilePowered)
        {
            if (movesInstantly)
            {transform.position = originalPosition + moveDirection;}
            else
            {StartCoroutine(MoveOverTime());}
        }
    }
    private IEnumerator MoveOverTime()
    {
        Vector3 startPos = transform.position;
        Vector3 targetPos = originalPosition + moveDirection;

        float elapsed = 0f;
        float duration = 1f / moveSpeed;

        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(startPos, targetPos, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;
    }
}