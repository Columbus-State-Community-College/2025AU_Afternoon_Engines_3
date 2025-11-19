using UnityEngine;

public class SpellSummonObject : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody summonedObject;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (summonedObject == null)
        {return;}

        Rigidbody projectile = Instantiate(summonedObject, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * 4.5f, ForceMode.Impulse);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
