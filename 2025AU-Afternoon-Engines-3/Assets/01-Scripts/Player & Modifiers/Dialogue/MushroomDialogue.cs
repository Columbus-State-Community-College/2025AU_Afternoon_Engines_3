using UnityEngine;

public class MushroomDialogue : MonoBehaviour
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
    public void crowOneQuest()
    {
        if (unlockManager.crowOneDone == true)
        {
            crowOneStandard();
        }
        else if (unlockManager.crowOneRock == true)
        {
            crowOneComplete();
        }
        else
        {
            NPCName = "Craw";
            dialogue = "Caw! Friend get rock for caw?";
            unlockManager.crowOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void crowOneComplete()
    {
        NPCName = "Craw";
        dialogue = "Squawk!! Rock rock! Caw give friend gift!";
        unlockManager.crowOneActive = false;
        unlockManager.crowOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowOneStandard()
    {
        NPCName = "Craw";
        dialogue = "Caw! Rock very yummy!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowTwoQuest()
    {
        if (unlockManager.crowTwoDone == true)
        {
            crowTwoStandard();
        }
        else if (unlockManager.crowTwoSmithGift == true)
        {
            crowTwoComplete();
        }
        else
        {
            NPCName = "Crowe";
            dialogue = "Chirrrrp! If friend help blacksmith me give gift! Want red gem for blacksmith!";
            unlockManager.crowTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void crowTwoComplete()
    {
        NPCName = "Crowe";
        dialogue = "Chipchip! Me see friend help blacksmith! Here gift!";
        unlockManager.crowTwoActive = false;
        unlockManager.crowTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowTwoStandard()
    {
        NPCName = "Crowe";
        dialogue = "Caw, me like blacksmith. Tap tap, bawk bawk.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowThreeQuest()
    {
        if (unlockManager.crowThreeDone == true)
        {
            crowThreeStandard();
        }
        else if (unlockManager.crowThreeTalkToHecate == true)
        {
            crowThreeComplete();
        }
        else
        {
            NPCName = "Squawk";
            dialogue = "Has bushy witch friend meet mushroom witch friend?";
            unlockManager.crowThreeActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void crowThreeComplete()
    {
        NPCName = "Squawk";
        dialogue = "Friend know other friend! Me happy!";
        unlockManager.crowThreeActive = false;
        unlockManager.crowThreeDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowThreeStandard()
    {
        NPCName = "Squawk";
        dialogue = "Squawk!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowFourQuest()
    {
        if (unlockManager.crowFourDone == true)
        {
            crowFourStandard();
        }
        else if (unlockManager.familiarSpellUnlocked == true)
        {
            crowFourComplete();
        }
        else
        {
            NPCName = "Caw";
            dialogue = "Caw caw? Friend have friend?";
            unlockManager.crowFourActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void crowFourComplete()
    {
        NPCName = "Caw";
        dialogue = "SQUAAA! Wolf scary! Friend control not friend please!";
        unlockManager.crowFourActive = false;
        unlockManager.crowFourDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void crowFourStandard()
    {
        NPCName = "Caw";
        dialogue = "Squa... fluffies are scary...";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void HecateQuestOne()
    {
        if (unlockManager.hecateOneDone == true)
        {
            HecateQuestTwo();
        }
        else if (unlockManager.hecateOneBug == true)
        {
            HecateCompleteOne();
        }
        else
        {
            NPCName = "Hecate";
            dialogue = "Hello old friend. I heard you wanted to get the town's trust. Good luck with that. I wouldn't bother.\nBut if you wish for some help I can provide. Help me get a bug and I'll give you a spell.";
            unlockManager.hecateOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void HecateCompleteOne()
    {
        NPCName = "Hecate";
        dialogue = "You truly want their trust? They're all so picky. Here's the promised spell.";
        unlockManager.hecateOneActive = false;
        unlockManager.hecateOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void HecateQuestTwo()
    {
        if (unlockManager.hecateTwoDone == true)
        {
            HecateQuestThree();
        }
        else if (unlockManager.hecateTwoCarrot == true)
        {
            HecateCompleteTwo();
        }
        else
        {
            NPCName = "Hecate";
            dialogue = "Hm? Bigger paper? You are being limited by paper size? Whatever... Ugh...\n Just, just... get a cave carrot for me, alright?";
            unlockManager.hecateTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void HecateCompleteTwo()
    {
        NPCName = "Hecate";
        dialogue = "Real determined, huh. I could never. Here's your bigger paper.";
        unlockManager.hecateTwoActive = false;
        unlockManager.hecateTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void HecateQuestThree()
    {
        if (unlockManager.hecateThreeDone == true)
        {
            HecateStandard();
        }
        else if (unlockManager.hecateThreeSeed == true)
        {
            HecateCompleteThree();
        }
        else
        {
            NPCName = "Hecate";
            dialogue = "Even bigger? Was that not enough? Alright, alright, whatever. Get some seeds down for me.";
            unlockManager.hecateThreeActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void HecateCompleteThree()
    {
        NPCName = "Hecate";
        dialogue = "Really? That wanting? Here's some bigger paper for you, Emmalesha. Don't get used to me calling you that.";
        unlockManager.hecateThreeActive = false;
        unlockManager.hecateThreeDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void HecateStandard()
    {
        NPCName = "Hecate";
        dialogue = "You've been ever brave compared to me, going through all this trouble. May the spirits guide you.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }
}
