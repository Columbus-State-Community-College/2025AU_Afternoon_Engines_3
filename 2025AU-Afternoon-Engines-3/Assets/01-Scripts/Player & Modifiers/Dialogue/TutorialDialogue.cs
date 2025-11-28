using UnityEngine;

public class TutorialDialogue : MonoBehaviour
{
    public DialogueChat dialogueChatScript;
    public string NPCName;
    public string dialogue;

    void Awake()
    {
        // if (!unlockManager)
        // {
        // GameObject unlockManagerGameObject = GameObject.FindGameObjectWithTag("UnlockManager");
        // unlockManager = unlockManagerGameObject.GetComponent<UnlockManager>();
        // }
        if (!dialogueChatScript)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            dialogueChatScript = player.GetComponent<DialogueChat>();
        }
    } 
    public void TutorialOne()
    {
        NPCName = "Crow";
        dialogue = "Good morning fair Witch! How was your slumber, good, I presume? I heard some commotion in your house, something about getting the folks to trust you?";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void TutorialTwo()
    {
        NPCName = "Crow";
        dialogue = "You can pick up objects and move them around, like that rock on the ground! I hear that you might be able to pick up other objects if you are strong enough.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void TutorialThree()
    {
        NPCName = "Crow";
        dialogue = "While I cannot cast spells, I can help you find a few, like this one, it's a Fire Spell, while it might be great to eat roasted boar, I've heard it's somewhat weak, but should always be enough to start a fire.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void TutorialFour()
    {
        NPCName = "Crow";
        dialogue = "Good job! Continue into town and start earning their trust.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowStand()
    {
        NPCName = "Crow";
        dialogue = "Caw! Squawk! Hi!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }
}