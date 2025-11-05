using UnityEngine;

public class SpellSelector : MonoBehaviour
{
    [Header("References")]
    public Transform castAttachPoint;
    private GameObject currentHeldSpell; // the currently spawned spell object
    private string currentSpellName;    
    [Header("Tier 1 Spells, 3x3")]
    public GameObject T1Spell_Fire;
    public GameObject T1Spell_Speed;
    public GameObject T1Spell_Electricity;
    public GameObject T1Spell_SpectralArrow;
    public GameObject T1Spell_SummonRock;
    public GameObject T1Spell_Heal;
    public GameObject T1Spell_Debug;
    public GameObject T1Spell_DispelSummons;

    [Header("Tier 2 Spells, 5x5")]
    // public GameObject T2Spell_FishingRod;
    // public GameObject T2Spell_Freeze;
    // public GameObject T2Spell_Wind;
    // public GameObject T2Spell_Boulder;
    // public GameObject T2Spell_Gravity;
    // public GameObject T2Spell_Explosion;
    // public GameObject T2Spell_Thunder;
    // public GameObject T2Spell_Unlock;
    // public GameObject T2Spell_VerdantGrowth;
    // public GameObject T2Spell_DispelOther;

    [Header("Tier 3 Spells, 7x7")]
    // public GameObject T3Spell_Flood;
    // public GameObject T3Spell_Decurse;
    // public GameObject T3Spell_Flight;
    // public GameObject T3Spell_Intangibility;
    // public GameObject T3Spell_Charm;
    // public GameObject T3Spell_Launch;
    // public GameObject T3Spell_SummonFamiliar;
    // public GameObject T3Spell_Enchant;
    // public GameObject T3Spell_FinalSpell;

    [HideInInspector] public static SpellSelector instance;
    // public static 
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SelectSpell("Fire");

        if (Input.GetKeyDown(KeyCode.Alpha2))
            SelectSpell("Speed");

        if (Input.GetKeyDown(KeyCode.Alpha3))
            SelectSpell("Electricity");

        if (Input.GetKeyDown(KeyCode.Alpha4))
            SelectSpell("SpectralArrow");

        if (Input.GetKeyDown(KeyCode.Alpha5))
            SelectSpell("SummonRock");

        if (Input.GetKeyDown(KeyCode.Alpha6))
            SelectSpell("Heal");

        if (Input.GetKeyDown(KeyCode.Alpha7))
            SelectSpell("Debug");
            
        if (Input.GetKeyDown(KeyCode.Alpha8))
            SelectSpell("DispelSummons");
    }
    public void SelectSpell(string spellName)
    {
        if (currentHeldSpell != null)
            Destroy(currentHeldSpell);

        // Pick the prefab
        GameObject selectedPrefab = null;
        switch (spellName)
        {
            case "Fire":
                selectedPrefab = T1Spell_Fire;
                break;
            case "Speed":
                selectedPrefab = T1Spell_Speed;
                break;
            case "Electricity":
                selectedPrefab = T1Spell_Electricity;
                break;
            case "SpectralArrow":
                selectedPrefab = T1Spell_SpectralArrow;
                break;
            case "SummonRock":
                selectedPrefab = T1Spell_SummonRock;
                break;
            case "Heal":
                selectedPrefab = T1Spell_Heal;
                break;
            case "Debug":
                selectedPrefab = T1Spell_Debug;
                break;
            case "DispelSummons":
                selectedPrefab = T1Spell_DispelSummons;
                break;
            default:
                return;
        }

        currentHeldSpell = Instantiate(selectedPrefab, castAttachPoint);
        currentHeldSpell.transform.localPosition = Vector3.zero;
        currentHeldSpell.transform.localRotation = Quaternion.identity;

        currentSpellName = spellName;   
    }
    public GameObject GetCurrentHeldSpell()
    {
        return currentHeldSpell;
    }
}
