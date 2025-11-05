
using UnityEngine;

public class SpellSpectralArrow : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody arrowProjectile;
    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
    }
    public override void ActivateSpell()
    {
        if (arrowProjectile == null)
        {
            return;
        }

        Rigidbody projectile = Instantiate(arrowProjectile, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * (40f * (1f + (0.7f * ModifierValue))), ForceMode.Impulse);
        Destroy(gameObject);
    }
}
