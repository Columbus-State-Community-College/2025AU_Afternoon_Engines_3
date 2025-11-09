using UnityEngine;

public class SpellSummonRock : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public Rigidbody rock;
    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}
    public override void ActivateSpell()
    {
        if (rock == null)
        {return;}

        Rigidbody projectile = Instantiate(rock, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * 3f, ForceMode.Impulse);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
