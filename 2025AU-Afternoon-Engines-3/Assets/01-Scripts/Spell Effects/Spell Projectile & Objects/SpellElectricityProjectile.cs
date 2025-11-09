using UnityEngine;

public class SpellElectricityProjectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        {return;}
        Powerable powerable = other.GetComponent<Powerable>();
        if (powerable != null)
        {powerable.TogglePower();}

        Destroy(gameObject);
    }
}
