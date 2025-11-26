using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveSlot : MonoBehaviour
{
    [Header("Slot Setup")]
    public int slotNumber = 1;
    public TitleScreen titleScreen;

    [Header("UI Text References")]
    public TextMeshProUGUI saveNameText;
    public TextMeshProUGUI progressText;
    public TextMeshProUGUI questText;

    [Header("Buttons")]
    public Button slotSelectButton; 
    public Button deleteSaveButton; 
    public GameObject deleteConfirmPanel;
    public Button confirmDeleteButton;
    public Button cancelDeleteButton;
    public GameObject highlightObject;

    private string keyLevel   => $"save{slotNumber}_level";
    private string keyName    => $"save{slotNumber}_name";
    private string keyProgress=> $"save{slotNumber}_progress";
    private string keyQuest   => $"save{slotNumber}_quest";

    private void Start()
    {
        RefreshSlot();

        deleteConfirmPanel.SetActive(false);

        confirmDeleteButton.onClick.AddListener(ConfirmDelete);
        cancelDeleteButton.onClick.AddListener(CancelDelete);
    }

    public void RefreshSlot()
    {
        bool hasData = PlayerPrefs.HasKey(keyLevel);

        slotSelectButton.interactable = true;

        if (!hasData)
        {
            saveNameText.text = "EMPTY SLOT";
            progressText.text = "";
            questText.text = "";

            deleteSaveButton.gameObject.SetActive(false);
        }
        else
        {
            saveNameText.text = PlayerPrefs.GetString(keyName, "Save");
            progressText.text = PlayerPrefs.GetString(keyProgress, "Progress 0/0");
            questText.text = PlayerPrefs.GetString(keyQuest, "No Quest");

            deleteSaveButton.gameObject.SetActive(true);
        }
    }
    public void OnSlotClicked()
    {
        titleScreen.SelectSlot(slotNumber);
    }

    public void OnDeleteRequested()
    {
        deleteConfirmPanel.SetActive(true);
    }

    void ConfirmDelete()
    {
        PlayerPrefs.DeleteKey(keyLevel);
        PlayerPrefs.DeleteKey(keyName);
        PlayerPrefs.DeleteKey(keyProgress);
        PlayerPrefs.DeleteKey(keyQuest);
        PlayerPrefs.Save();

        deleteConfirmPanel.SetActive(false);
        RefreshSlot();
    }

    void CancelDelete()
    {
        deleteConfirmPanel.SetActive(false);
    }
}