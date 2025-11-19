using UnityEngine;

public class UnlockManager : MonoBehaviour
{
    public static UnlockManager instance;
    public bool gameMenuOpen, dialogueActive;
    [Header("T1 Unlocks")]
    public bool parchment3x3;
    public bool fireSpellUnlocked, speedSpellUnlocked, electricitySpellUnlocked, spectralArrowSpellUnlocked, rockSpellUnlocked, healSpellUnlocked, debugSpellUnlocked, dispelPersonalSpellUnlocked;

    [Header("T2 Unlocks")]
    public bool parchment5x5;
    public bool fishingSpellUnlocked, freezeSpellUnlocked, windSpellUnlocked, boulderSpellUnlocked, gravitySpellUnlocked, explosionSpellUnlocked, thunderSpellUnlocked, unlockSpellUnlocked, verdantSpellUnlocked, dispelOtherSpellUnlocked;

    [Header("T3 Unlocks")]
    public bool parchment7x7;
    public bool floodSpellUnlocked, decurseSpellUnlocked, flightSpellUnlocked, intangibilitySpellUnlocked, charmSpellUnlocked, launchSpellUnlocked, familiarSpellUnlocked, enchantSpellUnlocked, theFinalSpellUnlocked;
 
    
    void Start()
    {
        if(instance == null)
        {instance = this;}
        else
        {if(instance != this)
        {Destroy(gameObject);}}
        DontDestroyOnLoad(gameObject);
    }
}
 