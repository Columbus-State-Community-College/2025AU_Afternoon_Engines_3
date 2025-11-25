using UnityEngine;
using System.Collections;

public class SpellGravityEffect : MonoBehaviour
{
    [HideInInspector] public float ModifierValue = 1f;

    public float lifetime = 8f;

    public float massMultiplier = 0.85f;

    private Rigidbody rb;
    private float originalMass;

    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;

        rb = PlayerController.instance.GetComponent<Rigidbody>();
        if (rb == null)
        {
            Destroy(gameObject);
            return;
        }
        originalMass = rb.mass;
        rb.mass = originalMass * (massMultiplier * ModifierValue);
        StartCoroutine(RevertMassAfterDelay());
    }

    private IEnumerator RevertMassAfterDelay()
    {
        yield return new WaitForSeconds(lifetime * ModifierValue);

        rb.mass = originalMass;

        Destroy(gameObject);
    }
}