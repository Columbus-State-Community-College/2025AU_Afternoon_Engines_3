using UnityEngine;

public class SpellFireProjectile : MonoBehaviour
{
    [HideInInspector] public float ModifierValue = 1f;
    public float lifetime = 4f;

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
        if (other.CompareTag("Flammable"))
        {
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}