using UnityEngine;

public class SpellWind : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody windProjectile;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (windProjectile == null)
        {return;}

        Rigidbody projectile = Instantiate(windProjectile, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * (32f * (1f + (0.2f * ModifierValue))), ForceMode.Impulse);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
