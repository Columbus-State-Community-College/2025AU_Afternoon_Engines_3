using UnityEngine;

public class SpellVerdantGrowth : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody growthIndicator;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (growthIndicator == null)
        {return;}

        Rigidbody projectile = Instantiate(growthIndicator, transform.position, transform.rotation);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
