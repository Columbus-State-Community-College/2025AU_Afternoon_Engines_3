using UnityEngine;

public class MushroomDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    public string speaking;

    public void crowOneQuest()
    {
        speaking = "Caw! Friend get rock for caw?";
        chatty.EnterDialogue(speaking);
    }

    public void crowOneComplete()
    {
        speaking = "Squawk!! Rock rock! Caw give friend gift!";
        chatty.EnterDialogue(speaking);
    }

    public void crowOneStandard()
    {
        speaking = "Caw! Rock very yummy!";
        chatty.EnterDialogue(speaking);
    }

    public void crowTwoQuest()
    {
        speaking = "Chirrrrp! If friend help blacksmith me give gift!";
        chatty.EnterDialogue(speaking);
    }

    public void crowTwoComplete()
    {
        speaking = "Chipchip! Me see friend help blacksmith! Here gift!";
        chatty.EnterDialogue(speaking);
    }

    public void crowTwoStandard()
    {
        speaking = "Caw, me like blacksmith. Tap tap, bawk bawk.";
        chatty.EnterDialogue(speaking);
    }

    public void crowThreeQuest()
    {
        speaking = "Has bushy witch friend meet mushroom witch friend?";
        chatty.EnterDialogue(speaking);
    }

    public void crowThreeComplete()
    {
        speaking = "Friend know other friend! Me happy!";
        chatty.EnterDialogue(speaking);
    }

    public void crowThreeStandard()
    {
        speaking = "Squawk!";
        chatty.EnterDialogue(speaking);
    }

    public void crowFourQuest()
    {
        speaking = "Caw caw? Friend have friend?";
        chatty.EnterDialogue(speaking);
    }

    public void crowFourComplete()
    {
        speaking = "SQUAAA! Wolf scary! Friend control not friend please!";
        chatty.EnterDialogue(speaking);
    }

    public void crowFourStandard()
    {
        speaking = "Squa... fluffies are scary...";
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestOne()
    {
        speaking = "Hello old friend. I heard you wanted to get the town's trust. Good luck with that. I wouldn't bother. " +
            "But if you wish for some help I can provide. Help me clear the weeds and I'll give you a spell.";
        chatty.EnterDialogue(speaking);
    }

    public void HecateCompleteOne()
    {
        speaking = "You truly want their trust? They're all so picky. Here's the promised spell.";
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestTwo()
    {
        speaking = "Hm? Bigger paper? You are being limited by paper size? Whatever, just... get a cave carrot for me, " +
            "alright?";
        chatty.EnterDialogue(speaking);
    }

    public void HecateCompleteTwo()
    {
        speaking = "Real determined, huh. I could never. Here's your bigger paper.";
        chatty.EnterDialogue(speaking);
    }

    public void HecateQuestThree()
    {
        speaking = "Even bigger? Was that not enough? Alright, alright, whatever. Get some seeds down for me.";
        chatty.EnterDialogue(speaking);
    }

    public void HecateCompleteThree()
    {
        speaking = "Really? That wanting? Here's some bigger paper for you, Emmalesha. Don't get used to me calling " +
            "you that.";
        chatty.EnterDialogue(speaking);
    }

    public void HecateStandard()
    {
        speaking = "You're braver than me, going through all this trouble. May spirits guide you.";
        chatty.EnterDialogue(speaking);
    }
}
