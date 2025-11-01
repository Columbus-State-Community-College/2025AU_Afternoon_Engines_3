using UnityEngine;
using TMPro;

public class DialogueChat : MonoBehaviour
{
    public TextMeshProUGUI dialogueBox; // This is the UI box where the dialogue will appear

    void Start()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    public void NoMoreDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    void ActiveDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
    }

    // This will be expanded and edited as specific NPCs are added.
    // The current two tags are test tags we can change out.
    // It is the same with the functions they point to, their contents will be changed.
    public void GetDialogue(string thisNPC)
    {
        if (thisNPC == "npc1")
        {
            QuestOne();
        }
        else if (thisNPC == "npc2")
        {
            QuestTwo();
        }
    }

    public void QuestOne()
    {
        dialogueBox.text = "This is a dialogue test!\nWith a new line too!";
        ActiveDialogue();
    }

    public void QuestTwo()
    {
        dialogueBox.text = "This is a different dialogue. There is no slash n to check for " +
            "overflow for a long line. Anyways, mimimi mimi mimimimi mimi kimi.";
        ActiveDialogue();
    }
}
