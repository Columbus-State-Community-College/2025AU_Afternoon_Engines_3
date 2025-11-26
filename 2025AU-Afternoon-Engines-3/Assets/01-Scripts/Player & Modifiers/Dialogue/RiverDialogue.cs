using UnityEngine;

public class RiverDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    UnlockManager manager;
    QuestList questy;
    public string speaking;

    public void CrowOneQuest()
    {
        if (manager.riverCrowOneDone = true)
        {
            CrowOneStandard();
        }
        else if (manager.riverCrowOneNut = true)
        {
            CrowOneComplete();
        }
        else
        {
            speaking = "Caw! Me find weird scroll but me not read! But me like nut! Trade nut for scroll?";
            manager.riverCrowOneActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void CrowOneComplete()
    {
        speaking = "CAW! Nut! Me thank friend for nut! Have scroll.";
        manager.riverCrowOneActive = false;
        manager.riverCrowOneDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void CrowOneStandard()
    {
        speaking = "Me like nut, squa.";
        chatty.EnterDialogue(speaking);
    }

    public void CrowTwoQuest()
    {
        if (manager.riverCrowTwoDone = true)
        {
            CrowTwoStandard();
        }
        else if (manager.riverCrowTwoFlower = true)
        {
            CrowTwoComplete();
        }
        else
        {
            speaking = "Chirrrp, me looking for snack flower but snack flower went into cave. Can friend get " +
                "my snack flower?";
            manager.riverCrowTwoActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void CrowTwoComplete()
    {
        speaking = "Chirrr! Snack flower! Friend thankth!";
        manager.riverCrowTwoActive = false;
        manager.riverCrowTwoDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void CrowTwoStandard()
    {
        speaking = "Snack flower very tasty!";
        chatty.EnterDialogue(speaking);
    }

    public void FemaleQuest()
    {
        if (manager.riverGirlDone = true)
        {
            FemaleStandard();
        }
        else if (manager.riverGirlGoldCarp = true)
        {
            FemaleComplete();
        }
        else
        {
            speaking = "Exucse me, ma'am? Can you bring me a fish from the top of the cliff? It's a golden carp.";
            manager.riverGirlActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FemaleComplete()
    {
        speaking = "Oh, thank you ma'am. Making a wondrous dish from this will surely please the king.";
        manager.riverGirlActive = false;
        manager.riverGirlDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FemaleStandard()
    {
        speaking = "Last I heard, the king's wife wasn't doing very well.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestOne()
    {
        if (manager.farmerOneDone = true)
        {
            FarmerQuestTwo();
        }
        else if (manager.farmerGreenFish = true)
        {
            FarmerCompleteOne();
        }
        else
        {
            speaking = "Hey there! I'm looking for some fish, but... I don't know how to fish. Can you get some for me? " +
                "The first fish I'm looking for is a green one.";
            manager.farmerOneActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteOne()
    {
        speaking = "Oh hey, you found it! Sweet! I'll add this to the pile.";
        manager.farmerOneDone = true;
        manager.farmerOneActive = false;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestTwo()
    {
        if (manager.farmerTwoDone = true)
        {
            FarmerQuestThree();
        }
        else if (manager.farmerBlueFish = true)
        {
            FarmerCompleteTwo();
        }
        else
        {
            speaking = "That's the first fish. The second fish is a sky blue color with white fins.";
            manager.farmerTwoActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteTwo()
    {
        speaking = "Sweet! I knew it lived around here somewhere.";
        manager.farmerTwoActive = false;
        manager.farmerTwoDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestThree()
    {
        if (manager.farmerThreeDone = true)
        {
            FarmerQuestFour();
        }
        else if (manager.farmerPurpleFish = true)
        {
            FarmerCompleteThree();
        }
        else
        {
            speaking = "That's two fish. Next on the list is a shiny purple fish.";
            manager.farmerThreeActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteThree()
    {
        speaking = "Oh, sweet! It's a lot shinier than what I was told.";
        manager.farmerThreeActive = false;
        manager.farmerThreeDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestFour()
    {
        if (manager.farmerFourDone = true)
        {
            FarmerQuestFive();
        }
        else if (manager.farmerRedFish = true)
        {
            FarmerCompleteFour();
        }
        else
        {
            speaking = "That's three. Next is a brilliant red fish.";
            manager.farmerFourActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteFour()
    {
        speaking = "Sweet! It's color is a lot less brilliant that the text said.";
        manager.farmerFourActive = false;
        manager.farmerFourDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestFive()
    {
        if (manager.farmerFiveDone = true)
        {
            FarmerQuestSix();
        }
        else if (manager.farmerOrangeFish = true)
        {
            FarmerCompleteFive();
        }
        else
        {
            speaking = "Four fish now. What's the next fish? Right, a wiggly orange fish.";
            manager.farmerFiveActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteFive()
    {
        speaking = "Sweet! It doesn't look very wiggly.";
        manager.farmerFiveActive = false;
        manager.farmerFiveDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestSix()
    {
        if (manager.farmerSixDone = true)
        {
            FarmerStandard();
        }
        else if (manager.farmerYellowFish = true)
        {
            FarmerCompleteSix();
        }
        else
        {
            speaking = "This should be the last fish... I think. I'll have to double check. It's a yellow fish.";
            manager.farmerSixActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void FarmerCompleteSix()
    {
        speaking = "I double checked, it's just six fish. And hey, sweet! You found it!";
        manager.farmerSixActive = false;
        manager.farmerSixDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void FarmerStandard()
    {
        speaking = "Time to see if I can make a Rainbow Fish Collective Platter... or whatever my brother called it.";
        chatty.EnterDialogue(speaking);
    }
}
