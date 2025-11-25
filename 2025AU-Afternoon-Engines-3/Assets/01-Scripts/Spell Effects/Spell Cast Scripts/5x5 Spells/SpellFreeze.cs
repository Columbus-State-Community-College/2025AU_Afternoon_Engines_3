using UnityEngine;

public class SpellFreeze : SpellBase
{
    //No functionality Until River Area Added
    [HideInInspector] public float ModifierValue = 1f;
    // public Rigidbody Freeze;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        //Duration & Effect Here
    }
}
