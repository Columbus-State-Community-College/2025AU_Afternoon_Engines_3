using UnityEngine;

public class UnlockManager : MonoBehaviour
{
    public static UnlockManager instance;
    public bool gameMenuOpen, dialogueActive;
    [Header("T1 Unlocks")]
    public bool parchment3x3;
    public bool fireSpell, speedSpell, electricitySpell, spectralArrowSpell, rockSpell, healSpell, debugSpell, dispelPersonalSpell;

    [Header("T2 Unlocks")]
    public bool parchment5x5;
    public bool fishingSpell, freezeSpell, windSpell, boulderSpell, gravitySpell, explosionSpell, thunderSpell, unlockSpell, verdantSpell, dispelOtherSpell;

    [Header("T3 Unlocks")]
    public bool parchment7x7;
    public bool floodSpell, decurseSpell, flightSpell, intangibilitySpell, charmSpell, launchSpell, familiarSpell, enchantSpell, theFinalSpell;
 
    
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
 