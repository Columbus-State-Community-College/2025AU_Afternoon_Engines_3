using UnityEngine;

public class RiverDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    UnlockManager manager;
    public string speaking;

    public void CrowOneQuest()
    {
        speaking = "Caw! Me find weird scroll but me not read! But me like nut! Trade nut for scroll?";
        chatty.EnterDialogue(speaking);
    }

    public void CrowOneComplete()
    {
        speaking = "CAW! Nut! Me thank friend for nut! Have scroll.";
        chatty.EnterDialogue(speaking);
    }

    public void CrowOneStandard()
    {
        speaking = "Me like nut, squa.";
        chatty.EnterDialogue(speaking);
    }

    public void CrowTwoQuest()
    {
        speaking = "Chirrrp, me looking for snack flower but snack flower went into cave. Can friend get " +
            "my snack flower?";
        chatty.EnterDialogue(speaking);
    }

    public void CrowTwoComplete()
    {
        speaking = "Chirrr! Snack flower! Friend thankth!";
        chatty.EnterDialogue(speaking);
    }

    public void CrowTwoStandard()
    {
        speaking = "Snack flower very tasty!";
        chatty.EnterDialogue(speaking);
    }

    public void FemaleQuest()
    {
        speaking = "Exucse me, ma'am? Can you bring me a fish from the top of the cliff? It's a golden carp.";
        chatty.EnterDialogue(speaking);
    }

    public void FemaleComplete()
    {
        speaking = "Oh, thank you ma'am. Making a wondrous dish from this will surely please the king.";
        chatty.EnterDialogue(speaking);
    }

    public void FemaleStandard()
    {
        speaking = "Last I heard, the king's wife wasn't doing very well.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestOne()
    {
        speaking = "Hey there! I'm looking for some fish, but... I don't know how to fish. Can you get some for me? " +
            "The first fish I'm looking for is a green one.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteOne()
    {
        speaking = "Oh hey, you found it! Sweet! I'll add this to the pile.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestTwo()
    {
        speaking = "That's the first fish. The second fish is a sky blue color with white fins.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteTwo()
    {
        speaking = "Sweet! I knew it lived around here somewhere.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestThree()
    {
        speaking = "That's two fish. Next on the list is a shiny purple fish.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteThree()
    {
        speaking = "Oh, sweet! It's a lot shinier than what I was told.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestFour()
    {
        speaking = "That's three. Next is a brilliant red fish.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteFour()
    {
        speaking = "Sweet! It's color is a lot less brilliant that the text said.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestFive()
    {
        speaking = "Four fish now. What's the next fish? Right, a wiggly orange fish.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteFive()
    {
        speaking = "Sweet! It doesn't look very wiggly.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerQuestSix()
    {
        speaking = "This should be the last fish... I think. I'll have to double check. It's a yellow fish.";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerCompleteSix()
    {
        speaking = "I double checked, it's just six fish. And hey, sweet! You found it!";
        chatty.EnterDialogue(speaking);
    }

    public void FarmerStandard()
    {
        speaking = "Time to see if I can make a Rainbow Fish Collective Platter... or whatever my brother called it.";
        chatty.EnterDialogue(speaking);
    }
}
