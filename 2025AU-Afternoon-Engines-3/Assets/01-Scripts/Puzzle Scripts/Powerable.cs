using UnityEngine;
using System.Collections;

public class Powerable : MonoBehaviour
{
    [Header("Toggle & Duration Settings (Puzzle Status)")]
    public bool powerStatus = false;
    public bool canTurnOff = false;
    public float powerDuration = 6f;

    private Coroutine powerRoutine;
    [Header("If the object should move while on, edit and allow below.")]
    public bool movesWhilePowered;
    public Vector3 moveDirection = new Vector3(1f, 2f, 1f);
    public void TogglePower()
    {
        if (powerStatus && !canTurnOff)
            return;

        powerStatus = !powerStatus;

        if (powerStatus)
        {
            OnPoweredOn();
        }
        else
        {
            OnPoweredOff();
        }

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
        
    }

    void OnPoweredOff()
    {
        
    }
}