using UnityEngine;
using TMPro;

public class DialogueChat : MonoBehaviour
{
    public TextMeshProUGUI dialogueBox; // This is the UI box where the dialogue will appear
    TutorialDialogue tutorial;

    void Start()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    public void NoMoreDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    public void ActiveDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
    }

    public void EnterDialogue(string chatter)
    {
        dialogueBox.text = chatter;
    }

    // This will be expanded and edited as specific NPCs are added.
    // The current two tags are test tags we can change out.
    // It is the same with the functions they point to, their contents will be changed.
    public void GetDialogue(string thisNPC)
    {
        if (thisNPC == "tutorial1")
        {
            tutorial.TutorialOne();
            ActiveDialogue();
        }
        else if (thisNPC == "tutorial2")
        {
            tutorial.TutorialTwo();
            ActiveDialogue();
        }
    }
}
