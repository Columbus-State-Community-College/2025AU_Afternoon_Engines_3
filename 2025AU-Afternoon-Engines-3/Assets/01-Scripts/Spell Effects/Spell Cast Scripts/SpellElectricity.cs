using UnityEngine;

public class SpellElectricity : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody zapProjectile;
    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
    }
    public override void ActivateSpell()
    {
        if (zapProjectile == null)
        {
            return;
        }

        Rigidbody projectile = Instantiate(zapProjectile, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * (32f * (1f + (0.2f * ModifierValue))), ForceMode.Impulse);
        Destroy(gameObject);
    }
}
