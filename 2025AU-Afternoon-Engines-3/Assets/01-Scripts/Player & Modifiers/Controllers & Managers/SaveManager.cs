using UnityEngine;

public static class SaveManager
{
    public static void SaveGame(
        int slot, 
        string sceneName, 
        string progress, 
        string quest,
        string saveName = ""
    )
    {
        string key_level = $"save{slot}_level";
        string key_name = $"save{slot}_name";
        string key_progress = $"save{slot}_progress";
        string key_quest = $"save{slot}_quest";

        if (string.IsNullOrEmpty(saveName))
            saveName = $"Save Slot {slot}";

        PlayerPrefs.SetString(key_level, sceneName);
        PlayerPrefs.SetString(key_name, saveName);
        PlayerPrefs.SetString(key_progress, progress);
        PlayerPrefs.SetString(key_quest, quest);

        PlayerPrefs.Save();
    }
}