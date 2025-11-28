using UnityEngine;

public class CaveDialogue : MonoBehaviour
{
    public DialogueChat dialogueChatScript;
    public repTracker reputationTracker;
    public UnlockManager unlockManager;
    public QuestList questList;
    public string NPCName;
    public string dialogue;
 
    void Awake()
    {
        if (!dialogueChatScript)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            dialogueChatScript = player.GetComponent<DialogueChat>();
        }
    } 
    void FixedUpdate()
    {
        if (!unlockManager)
        {FindComponent();}
    }
    void FindComponent()
    {
        GameObject unlockManagerGameObject = GameObject.FindGameObjectWithTag("UnlockManager");
        unlockManager = unlockManagerGameObject.GetComponent<UnlockManager>();
    }
        public void DwarfOneStandard()
    {
        NPCName = "Hiyyayiyayi";
        dialogue = "Hahahahaha... Hibbabibabi stuck in hole!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void DwarfTwoStandard()
    {
        NPCName = "Hakkikika";
        dialogue = "Hakkikakika think Hibbabibabi in hole funny. Hiyyayiyayi no find funny.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void DwarfThreeQuest()
    {
        if (unlockManager.dwarfDone == true)
        {
            DwarfThreeStandard();
        }
        else if (unlockManager.dwarfFlower == true)
        {
            DwarfThreeComplete();
        }
        else
        {
            NPCName = "Hiqqaqiqaqi";
            dialogue = "Hiqqaqiqaqi want flower. Tall person bring flower? Hiqqaqiqaqi want tiny bright flower.";
            unlockManager.dwarfActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void DwarfThreeComplete()
    {
        NPCName = "Hiqqaqiqaqi";
        dialogue = "Tall person bring flower! Hiqqaqiqaqi happy!";
        unlockManager.dwarfActive = false;
        unlockManager.dwarfDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void DwarfThreeStandard()
    {
        NPCName = "Hiqqaqiqaqi";
        dialogue = "Hiqqaqiqaqi think Hakkikakika, Hibbabibabi, and Hiyyayiyayi stupid.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }
}
