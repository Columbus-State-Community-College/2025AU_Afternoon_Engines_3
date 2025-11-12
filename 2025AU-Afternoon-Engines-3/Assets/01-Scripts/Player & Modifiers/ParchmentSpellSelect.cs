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
        { "010110111", "Fire" },
        { "010111101", "Speed" },
        { "110101011", "Electricity" },
        { "110101110", "SpectralArrow" },
        { "101010111", "SummonRock" },
        { "010101010", "Heal" },
        { "111100011", "Debug" },
        { "101011111", "DispelSummons" },
    };

    private Dictionary<string, Color> spellColors = new Dictionary<string, Color>()
    {
        { "Fire", new Color(1f, 0.3f, 0f) },           // orange-red
        { "Speed", new Color(0.2f, 0.8f, 1f) },        // light blue
        { "Electricity", new Color(1f, 1f, 0.3f) },    // yellow-white
        { "SpectralArrow", new Color(0.6f, 0.3f, 1f) },// purple
        { "SummonRock", new Color(0.4f, 0.25f, 0.1f) },// brown
        { "Heal", new Color(0.3f, 1f, 0.3f) },         // green
        { "Debug", Color.yellow },
        { "DispelSummons", Color.magenta }
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
            Debug.LogWarning("UnlockManager instance not found!");
            return false;
        }

        var unlocks = UnlockManager.instance;
        switch (spellName)
        {
            case "Fire": return unlocks.fireSpellUnlocked;
            case "Speed": return unlocks.speedSpellUnlocked;
            case "Electricity": return unlocks.electricitySpellUnlocked;
            case "SpectralArrow": return unlocks.spectralArrowSpellUnlocked;
            case "SummonRock": return unlocks.rockSpellUnlocked;
            case "Heal": return unlocks.healSpellUnlocked;
            case "Debug": return unlocks.debugSpellUnlocked;
            case "DispelSummons": return unlocks.dispelPersonalSpellUnlocked;
            default:
                Debug.LogWarning($"No unlock flag defined for spell: {spellName}");
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