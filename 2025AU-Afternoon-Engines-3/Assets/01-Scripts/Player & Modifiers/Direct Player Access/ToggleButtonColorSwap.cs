using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ToggleButtonColorSwap : MonoBehaviour
{
    public Image background;
    public Color activeColor = new Color(0.8f, 0.8f, 0.8f); // color when toggle is ON normally
    public Color inactiveColor = Color.white;               // color when OFF normally

    // optional: color used temporarily by parchment when a spell is created
    private Color temporaryColor = default;
    private bool usingTemporaryColor = false;

    private Toggle toggle;
    private Color originalColor;

    void Awake()
    {
        toggle = GetComponent<Toggle>();
        if (background == null)
            background = GetComponent<Image>();

        if (background != null)
            originalColor = background.color;

        toggle.onValueChanged.AddListener(OnToggleChanged);
        UpdateColor(toggle.isOn);
    }

    private void OnToggleChanged(bool isOn)
    {
        // If a temporary color is active, keep it until explicitly reset
        if (!usingTemporaryColor)
            UpdateColor(isOn);
    }

    private void UpdateColor(bool isOn)
    {
        if (background == null) return;
        background.color = isOn ? activeColor : inactiveColor;
    }

    // --- PUBLIC API used by ParchmentSpellSelect ---

    // Temporarily set this toggle's displayed color (used when a spell is matched)
    public void SetTemporaryColor(Color c)
    {
        if (background == null) return;
        temporaryColor = c;
        usingTemporaryColor = true;
        background.color = temporaryColor;
    }

    // Restore normal behavior (uses toggle state colors again)
    public void ResetColor()
    {
        usingTemporaryColor = false;
        UpdateColor(toggle != null && toggle.isOn);
    }

    // Optional helper if you want to force restore original sprite color
    public void RestoreOriginalColor()
    {
        if (background == null) return;
        usingTemporaryColor = false;
        background.color = originalColor;
    }
}