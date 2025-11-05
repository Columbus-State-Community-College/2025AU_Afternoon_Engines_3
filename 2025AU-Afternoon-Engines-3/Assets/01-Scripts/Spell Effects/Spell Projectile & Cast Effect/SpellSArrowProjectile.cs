using UnityEngine;

public class SpellSArrowProjectile : MonoBehaviour
{
    [HideInInspector] public float ModifierValue = 1f;
    public float lifetime = 2f;

    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
        Destroy(gameObject, lifetime * ModifierValue);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            return;
        }

        if (other.CompareTag("Breakable"))
        {
            Destroy(other.gameObject);
        }
        
        Destroy(gameObject);
    }
}