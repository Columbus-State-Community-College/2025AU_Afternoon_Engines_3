using UnityEngine;

public class RiverDialogue : MonoBehaviour
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
    public void CrowOneQuest()
    {
        if (unlockManager.riverCrowOneDone == true)
        {
            CrowOneStandard();
        }
        else if (unlockManager.riverCrowOneNut == true)
        {
            CrowOneComplete();
        }
        else
        {
            NPCName = "Coo";
            dialogue = "Caw! Me find weird scroll but me not read! But me like nut! Trade nut for scroll?";
            unlockManager.riverCrowOneActive = true;
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void CrowOneComplete()
    {
        NPCName = "Coo";
        dialogue = "CAW! Nut! Me thank friend for nut! Have scroll.";
        unlockManager.riverCrowOneActive = false;
        unlockManager.riverCrowOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowOneStandard()
    {
        NPCName = "Coo";
        dialogue = "Me like nut, squa.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowTwoQuest()
    {
        if (unlockManager.riverCrowTwoDone == true)
        {
            CrowTwoStandard();
        }
        else if (unlockManager.riverCrowTwoFlower == true)
        {
            CrowTwoComplete();
        }
        else
        {
            NPCName = "Cu";
            dialogue = "Chirrrp, me looking for snack flower but snack flower went into cave. Can friend get " +
                "my snack flower?";
            unlockManager.riverCrowTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void CrowTwoComplete()
    {
        NPCName = "Cu";
        dialogue = "Chirrr! Snack flower! Friend thankth!";
        unlockManager.riverCrowTwoActive = false;
        unlockManager.riverCrowTwoDone = true;
        questList.whatQuestSeen();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowTwoStandard()
    {
        NPCName = "Cu";
        dialogue = "Snack flower very tasty!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FemaleQuest()
    {
        if (unlockManager.riverGirlDone == true)
        {
            FemaleStandard();
        }
        else if (unlockManager.riverGirlGoldCarp == true)
        {
            FemaleComplete();
        }
        else
        {
            NPCName = "Nasha";
            dialogue = "Exucse me, ma'am? Can you bring me a fish from the top of the cliff? It's a golden carp.";
            unlockManager.riverGirlActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FemaleComplete()
    {
        NPCName = "Nasha";
        dialogue = "Oh, thank you ma'am. Making a wondrous dish from this will surely please the king.";
        unlockManager.riverGirlActive = false;
        unlockManager.riverGirlDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FemaleStandard()
    {
        NPCName = "Nasha";
        dialogue = "Last I heard, the king's wife wasn't doing very well.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestOne()
    {
        if (unlockManager.farmerOneDone == true)
        {
            FarmerQuestTwo();
        }
        else if (unlockManager.farmerGreenFish == true)
        {
            FarmerCompleteOne();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "Hey there! I'm looking for some fish, but... I don't know how to fish. Can you get some for me? " +
                "The first fish I'm looking for is a green one.";
            unlockManager.farmerOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteOne()
    {
        NPCName = "Oran";
        dialogue = "Oh hey, you found it! Sweet! I'll add this to the pile.";
        unlockManager.farmerOneDone = true;
        unlockManager.farmerOneActive = false;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestTwo()
    {
        if (unlockManager.farmerTwoDone == true)
        {
            FarmerQuestThree();
        }
        else if (unlockManager.farmerBlueFish == true)
        {
            FarmerCompleteTwo();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "That's the first fish. The second fish is a sky blue color with white fins.";
            unlockManager.farmerTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteTwo()
    {
        NPCName = "Oran";
        dialogue = "Sweet! I knew it lived around here somewhere.";
        unlockManager.farmerTwoActive = false;
        unlockManager.farmerTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestThree()
    {
        if (unlockManager.farmerThreeDone == true)
        {
            FarmerQuestFour();
        }
        else if (unlockManager.farmerPurpleFish == true)
        {
            FarmerCompleteThree();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "That's two fish. Next on the list is a shiny purple fish.";
            unlockManager.farmerThreeActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteThree()
    {
        NPCName = "Oran";
        dialogue = "Oh, sweet! It's definitely a lot shinier than what I was told.";
        unlockManager.farmerThreeActive = false;
        unlockManager.farmerThreeDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestFour()
    {
        if (unlockManager.farmerFourDone == true)
        {
            FarmerQuestFive();
        }
        else if (unlockManager.farmerRedFish == true)
        {
            FarmerCompleteFour();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "That makes three. Next is a brilliant red fish.";
            unlockManager.farmerFourActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteFour()
    {
        NPCName = "Oran";
        dialogue = "Sweet! Its color is a lot less brilliant than the text said.";
        unlockManager.farmerFourActive = false;
        unlockManager.farmerFourDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestFive()
    {
        if (unlockManager.farmerFiveDone == true)
        {
            FarmerQuestSix();
        }
        else if (unlockManager.farmerOrangeFish == true)
        {
            FarmerCompleteFive();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "Four fish now. What's the next fish? Right, a wiggly orange fish.";
            unlockManager.farmerFiveActive = true;
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteFive()
    {
        NPCName = "Oran";
        dialogue = "Sweet! It doesn't look very wiggly.";
        unlockManager.farmerFiveActive = false;
        unlockManager.farmerFiveDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerQuestSix()
    {
        if (unlockManager.farmerSixDone == true)
        {
            FarmerStandard();
        }
        else if (unlockManager.farmerYellowFish == true)
        {
            FarmerCompleteSix();
        }
        else
        {
            NPCName = "Oran";
            dialogue = "This should be the last fish... I think. I'll have to double check. It's a yellow fish.";
            unlockManager.farmerSixActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FarmerCompleteSix()
    {
        NPCName = "Oran";
        dialogue = "I double checked, it's just six fish. And hey, sweet! You found it!";
        unlockManager.farmerSixActive = false;
        unlockManager.farmerSixDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FarmerStandard()
    {
        NPCName = "Oran";
        dialogue = "Time to see if I can make a Rainbow Fish Collective Platter... or whatever my brother called it.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }
}
