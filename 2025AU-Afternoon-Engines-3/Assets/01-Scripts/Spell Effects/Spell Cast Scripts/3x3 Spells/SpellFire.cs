using UnityEngine;

public class SpellFire : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody fireballProjectile;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (fireballProjectile == null)
        {return;}

        Rigidbody projectile = Instantiate(fireballProjectile, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * (25f * (1f + (0.2f * ModifierValue))), ForceMode.Impulse);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
