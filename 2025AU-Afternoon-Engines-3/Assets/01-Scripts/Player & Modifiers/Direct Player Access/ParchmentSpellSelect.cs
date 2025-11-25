using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ParchmentSpellSelect : MonoBehaviour
{
    [Header("Combination Input")]
    [Tooltip("Assign the 9 Toggle buttons in order (top-left to bottom-right, etc).")]
    public List<Toggle> combinationToggles = new List<Toggle>();

    [Header("References")]
    public TMP_Text selectedSpellNameText;
    public SpellSelector spellSelector;
    public bool spellCreated;

    private Dictionary<string, string> spellCombinations = new Dictionary<string, string>()
    {
        //3x3 Spell Inputs, uses Center of the Grid when the Tier 2 and Tier 3 parchment are unlocked..
        { "0000000100011000111000000", "Fire" },
        { "0000000100011100101000000", "Speed" },
        { "0000001100010100011000000", "Electricity" },
        { "0000001100010100110000000", "SpectralArrow" },
        { "0000001010001000111000000", "SummonRock" },
        { "0000000100010100010000000", "Heal" },
        { "0000001110010000011000000", "Debug" },
        { "0000001010001100111000000", "DispelSummons" },
        //5x5 Spell Inputs, uses Center of the Grid when the Tier 3 Parchment is unlocked.
        { "0100010111101000001100001", "FishingNet" },
        { "1010101010100010101010101", "Freeze" },
        { "0010101010011011011011000", "Wind" },
        { "0010001110111111111101110", "Boulder" },
        { "1011011001101101100110010", "Gravity" },
        { "0011101000011101111101110", "Explosion" },
        { "0010101010110100110011100", "Thunder" },
        { "0011011000001001101000100", "UnlockLockpick" },
        { "0101001001101100110010010", "VerdantGrowth" },
        { "1011001011011001011001101", "DispelOther" }
    };

    private Dictionary<string, Color> spellColors = new Dictionary<string, Color>()
    {
        { "Fire",           new Color(1.00f, 0.30f, 0.00f) },
        { "Speed",          new Color(0.20f, 0.80f, 1.00f) },
        { "Electricity",    new Color(1.00f, 1.00f, 0.30f) },
        { "SpectralArrow",  new Color(0.60f, 0.30f, 1.00f) },
        { "SummonRock",     new Color(0.40f, 0.25f, 0.10f) },
        { "Heal",           new Color(0.30f, 1.00f, 0.30f) },
        { "Debug",              Color.yellow               },
        { "DispelSummons",      Color.magenta              },
        { "FishingNet",     new Color(0.70f, 0.82f, 1.00f) },  
        { "Explosion",      new Color(0.78f, 0.60f, 0.72f) },  
        { "Freeze",         new Color(0.92f, 0.92f, 0.92f) },  
        { "Thunder",        new Color(0.98f, 0.90f, 0.45f) },  
        { "Wind",           new Color(0.80f, 0.90f, 1.00f) },  
        { "UnlockLockpick", new Color(0.78f, 0.91f, 0.70f) },  
        { "Boulder",        new Color(0.78f, 0.36f, 0.22f) },  
        { "VerdantGrowth",  new Color(0.47f, 0.73f, 0.36f) }, 
        { "Gravity",        new Color(0.74f, 0.65f, 0.90f) },  
        { "DispelOther",    new Color(1.00f, 0.78f, 0.80f) },
    };

    private void Start()
    {
        foreach (var toggle in combinationToggles)
            toggle.onValueChanged.AddListener(delegate { OnToggleChanged(); });
    }

    private void OnEnable()
    {
        spellCreated = false;
        ResetCombination();
    }

    private void OnDisable()
    {
        spellCreated = false;
        ResetCombination();

        ResetToggleColors();
    }

    private void OnToggleChanged()
    {
        string key = GetCombinationKey();

        if (spellCombinations.TryGetValue(key, out string spellName))
        {

            if (!IsSpellUnlocked(spellName))
            {
                Debug.LogWarning($"Spell '{spellName}' is locked and cannot be selected yet.");
                return;
            }

            Debug.Log($"Combination matched: {spellName}");

            if (selectedSpellNameText != null)
                selectedSpellNameText.text = $"Selected: {spellName}";

            if (spellSelector != null)
                spellSelector.SelectSpell(spellName);

            spellCreated = true;

            if (spellColors.TryGetValue(spellName, out Color color))
                ApplySpellColor(color);

            ResetCombination();
        }
        else
        {
            if (!spellCreated && selectedSpellNameText != null)
                selectedSpellNameText.text = "No spell selected";
        }
    }

    private string GetCombinationKey()
    {
        string key = "";
        foreach (var toggle in combinationToggles)
            key += toggle.isOn ? "1" : "0";
        return key;
    }

    public void ResetCombination()
    {
        foreach (var toggle in combinationToggles)
            toggle.isOn = false;

        if (selectedSpellNameText != null && !spellCreated)
            selectedSpellNameText.text = "No spell selected";

        if (!spellCreated)
            ResetToggleColors();
    }

    private bool IsSpellUnlocked(string spellName)
    {
        if (UnlockManager.instance == null)
        {
            return false;
        }

        var unlocks = UnlockManager.instance;
        switch (spellName)
        {
            // 3x3 Spells
            case "Fire":                return unlocks.fireSpellUnlocked;
            case "Speed":               return unlocks.speedSpellUnlocked;
            case "Electricity":         return unlocks.electricitySpellUnlocked;
            case "SpectralArrow":       return unlocks.spectralArrowSpellUnlocked;
            case "SummonRock":          return unlocks.rockSpellUnlocked;
            case "Heal":                return unlocks.healSpellUnlocked;
            case "Debug":               return unlocks.debugSpellUnlocked;
            case "DispelSummons":       return unlocks.dispelPersonalSpellUnlocked;
            // 5x5 Spells
            case "FishingNet":          return unlocks.fishingSpellUnlocked;
            case "Freeze":              return unlocks.freezeSpellUnlocked;
            case "Wind":                return unlocks.windSpellUnlocked;
            case "Boulder":             return unlocks.boulderSpellUnlocked;
            case "Gravity":             return unlocks.gravitySpellUnlocked;
            case "Explosion":           return unlocks.explosionSpellUnlocked;
            case "Thunder":             return unlocks.thunderSpellUnlocked;
            case "UnlockLockpick":      return unlocks.unlockSpellUnlocked;
            case "VerdantGrowth":       return unlocks.verdantSpellUnlocked;
            case "DispelOther":         return unlocks.dispelOtherSpellUnlocked;

            default:
                return false;
        }
    }

    private void ApplySpellColor(Color color)
    {
        foreach (var toggle in combinationToggles)
        {
            if (!toggle.isOn) continue;

            var colorSwap = toggle.GetComponent<ToggleButtonColorSwap>();
            if (colorSwap != null)
                colorSwap.SetTemporaryColor(color);
            else
            {
                var img = toggle.GetComponent<Image>();
                if (img != null)
                    img.color = color;
            }
        }
    }

    private void ResetToggleColors()
    {
        foreach (var toggle in combinationToggles)
        {
            var colorSwap = toggle.GetComponent<ToggleButtonColorSwap>();
            if (colorSwap != null)
                colorSwap.ResetColor();
            else
            {
                var img = toggle.GetComponent<Image>();
                if (img != null)
                    img.color = Color.white;
            }
        }
    }
}