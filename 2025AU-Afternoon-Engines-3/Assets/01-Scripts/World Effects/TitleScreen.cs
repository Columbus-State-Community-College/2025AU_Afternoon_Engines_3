using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleScreen : MonoBehaviour
{
    [Header("Menu References")]
    public GameObject OptionsMenu;

    [Header("Save Info")]
    public int selectedSlot = 0;
    private const int totalSlots = 2;
    public GameObject saveSelectMenu;
    public SaveSlot[] allSlots;
    public TextMeshProUGUI selectedSaveNameText;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void SelectSlot(int slot)
    {
        selectedSlot = slot;

        foreach (SaveSlot s in allSlots)
        {
            bool isSelected = (s.slotNumber == slot);
        }
        UpdateSelectedSaveNameUI(slot);
    }
    public void OpenSaveSelectMenu()
    {
        saveSelectMenu.SetActive(true);

        foreach (var slot in allSlots)
        {slot.RefreshSlot();}
        UpdateSelectedSaveNameUI(selectedSlot);
    }

    public bool SaveExists(int slot)
    { return PlayerPrefs.HasKey($"save{slot}_level"); }

    public void StartNewGame()
    {
        string startingScene = "Emmalesha's Woods (Tutorial)";

        PlayerPrefs.SetString($"save{selectedSlot}_level", startingScene);
        PlayerPrefs.SetString($"save{selectedSlot}_name", $"Save Slot {selectedSlot}");
        PlayerPrefs.SetString($"save{selectedSlot}_progress", "Progress 0/0");
        PlayerPrefs.SetString($"save{selectedSlot}_quest", "No Quest");

        PlayerPrefs.Save();

        SceneManager.LoadScene(startingScene);
    }
    private void UpdateSelectedSaveNameUI(int slot)
    {
        if (slot == 0)
        {
            selectedSaveNameText.text = "No Save Selected";
            return;
        }

        string keyName = $"save{slot}_name";

        if (PlayerPrefs.HasKey(keyName))
        {
            selectedSaveNameText.text = PlayerPrefs.GetString(keyName);
        }
        else
        {
            selectedSaveNameText.text = $"Empty Slot {slot}";
        }
    }
    public void StartGame()
{
    if (selectedSlot == 0)
    {
        saveSelectMenu.SetActive(true);
        return;
    }

    if (SaveExists(selectedSlot))
    {LoadGame();}
    else
    {StartNewGame();}
}
    public void LoadGame()
    {
        string savedLevel = PlayerPrefs.GetString($"save{selectedSlot}_level");
        SceneManager.LoadScene(savedLevel);
    }

    public void SaveGame(string currentScene)
    {
        PlayerPrefs.SetString($"save{selectedSlot}_level", currentScene);
        PlayerPrefs.Save();
    }

    public void DeleteSave(int slot)
    {PlayerPrefs.DeleteKey($"save{slot}_level");}

    public void QuitGame()
    {Application.Quit();}
}