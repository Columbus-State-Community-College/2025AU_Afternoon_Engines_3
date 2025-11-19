using UnityEngine;

public class SpellFishingNet : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    // public Rigidbody Freeze;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        //Duration & Effect Here
    }
}
