using UnityEngine;

public class MushroomDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    UnlockManager manager;
    QuestList questy;
    public string speaking;

    public void crowOneQuest()
    {
        if (manager.crowOneDone == true)
        {
            crowOneStandard();
        }
        else if (manager.crowOneRock == true)
        {
            crowOneComplete();
        }
        else
        {
            speaking = "Caw! Friend get rock for caw?";
            manager.crowOneActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void crowOneComplete()
    {
        speaking = "Squawk!! Rock rock! Caw give friend gift!";
        manager.crowOneActive = false;
        manager.crowOneDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void crowOneStandard()
    {
        speaking = "Caw! Rock very yummy!";
        chatty.EnterDialogue(speaking);
    }

    public void crowTwoQuest()
    {
        if (manager.crowTwoDone == true)
        {
            crowTwoStandard();
        }
        else if (manager.crowTwoSmithGift == true)
        {
            crowTwoComplete();
        }
        else
        {
            speaking = "Chirrrrp! If friend help blacksmith me give gift! Want red gem for blacksmith!";
            manager.crowTwoActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void crowTwoComplete()
    {
        speaking = "Chipchip! Me see friend help blacksmith! Here gift!";
        manager.crowTwoActive = false;
        manager.crowTwoDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void crowTwoStandard()
    {
        speaking = "Caw, me like blacksmith. Tap tap, bawk bawk.";
        chatty.EnterDialogue(speaking);
    }

    public void crowThreeQuest()
    {
        if (manager.crowThreeDone == true)
        {
            crowThreeStandard();
        }
        else if (manager.crowThreeTalkToHecate == true)
        {
            crowThreeComplete();
        }
        else
        {
            speaking = "Has bushy witch friend meet mushroom witch friend?";
            manager.crowThreeActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void crowThreeComplete()
    {
        speaking = "Friend know other friend! Me happy!";
        manager.crowThreeActive = false;
        manager.crowThreeDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void crowThreeStandard()
    {
        speaking = "Squawk!";
        chatty.EnterDialogue(speaking);
    }

    public void crowFourQuest()
    {
        if (manager.crowFourDone == true)
        {
            crowFourStandard();
        }
        else if (manager.familiarSpellUnlocked == true)
        {
            crowFourComplete();
        }
        else
        {
            speaking = "Caw caw? Friend have friend?";
            manager.crowFourActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void crowFourComplete()
    {
        speaking = "SQUAAA! Wolf scary! Friend control not friend please!";
        manager.crowFourActive = false;
        manager.crowFourDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void crowFourStandard()
    {
        speaking = "Squa... fluffies are scary...";
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestOne()
    {
        if (manager.hecateOneDone == true)
        {
            HecateQuestTwo();
        }
        else if (manager.hecateOneBug == true)
        {
            HecateCompleteOne();
        }
        else
        {
            speaking = "Hello old friend. I heard you wanted to get the town's trust. Good luck with that. I wouldn't bother. " +
                "But if you wish for some help I can provide. Help me get a bug and I'll give you a spell.";
            manager.hecateOneActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void HecateCompleteOne()
    {
        speaking = "You truly want their trust? They're all so picky. Here's the promised spell.";
        manager.hecateOneActive = false;
        manager.hecateOneDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestTwo()
    {
        if (manager.hecateTwoDone == true)
        {
            HecateQuestThree();
        }
        else if (manager.hecateTwoCarrot == true)
        {
            HecateCompleteTwo();
        }
        else
        {
            speaking = "Hm? Bigger paper? You are being limited by paper size? Whatever, just... get a cave carrot for me, " +
                "alright?";
            manager.hecateTwoActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void HecateCompleteTwo()
    {
        speaking = "Real determined, huh. I could never. Here's your bigger paper.";
        manager.hecateTwoActive = false;
        manager.hecateTwoDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestThree()
    {
        if (manager.hecateThreeDone == true)
        {
            HecateStandard();
        }
        else if (manager.hecateThreeSeed == true)
        {
            HecateCompleteThree();
        }
        else
        {
            speaking = "Even bigger? Was that not enough? Alright, alright, whatever. Get some seeds down for me.";
            manager.hecateThreeActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void HecateCompleteThree()
    {
        speaking = "Really? That wanting? Here's some bigger paper for you, Emmalesha. Don't get used to me calling " +
            "you that.";
        manager.hecateThreeActive = false;
        manager.hecateThreeDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void HecateStandard()
    {
        speaking = "You're braver than me, going through all this trouble. May spirits guide you.";
        chatty.EnterDialogue(speaking);
    }
}
