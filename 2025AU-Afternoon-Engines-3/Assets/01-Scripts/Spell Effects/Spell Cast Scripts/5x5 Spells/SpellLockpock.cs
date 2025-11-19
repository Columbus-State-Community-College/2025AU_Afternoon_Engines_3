using UnityEngine;

public class SpellLockpock : SpellBase
{
    //No Functionality Until Ruins area locked Gates exist
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody lockProjectile;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (lockProjectile == null)
        {return;}

        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
