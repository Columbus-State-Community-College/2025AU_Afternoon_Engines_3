using UnityEngine;

public class SpellDebug : SpellBase
{
    public override void ActivateSpell()
    {
        if (UnlockManager.instance == null)
        {
            return;
        }

        UnlockManager unlockableItem = UnlockManager.instance;

        // ----- T1 -----
        unlockableItem.parchment3x3 = true;
        unlockableItem.fireSpellUnlocked = true;
        unlockableItem.speedSpellUnlocked = true;
        unlockableItem.electricitySpellUnlocked = true;
        unlockableItem.spectralArrowSpellUnlocked = true;
        unlockableItem.rockSpellUnlocked = true;
        unlockableItem.healSpellUnlocked = true;
        unlockableItem.debugSpellUnlocked = true;
        unlockableItem.dispelPersonalSpellUnlocked = true;

        // ----- T2 -----
        unlockableItem.parchment5x5 = true;
        unlockableItem.fishingSpellUnlocked = true;
        unlockableItem.freezeSpellUnlocked = true;
        unlockableItem.windSpellUnlocked = true;
        unlockableItem.boulderSpellUnlocked = true;
        unlockableItem.gravitySpellUnlocked = true;
        unlockableItem.explosionSpellUnlocked = true;
        unlockableItem.thunderSpellUnlocked = true;
        unlockableItem.unlockSpellUnlocked = true;
        unlockableItem.verdantSpellUnlocked = true;
        unlockableItem.dispelOtherSpellUnlocked = true;

        // ----- T3 -----
        unlockableItem.parchment7x7 = true;
        unlockableItem.floodSpellUnlocked = true;
        unlockableItem.decurseSpellUnlocked = true;
        unlockableItem.flightSpellUnlocked = true;
        unlockableItem.intangibilitySpellUnlocked = true;
        unlockableItem.charmSpellUnlocked = true;
        unlockableItem.launchSpellUnlocked = true;
        unlockableItem.familiarSpellUnlocked = true;
        unlockableItem.enchantSpellUnlocked = true;
        unlockableItem.theFinalSpellUnlocked = true;

        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}