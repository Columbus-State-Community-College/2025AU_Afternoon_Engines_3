using UnityEngine;

public class TutorialDialogue : MonoBehaviour
{
    DialogueChat chatty;
    public string speaking;

    public void TutorialOne()
    {
        speaking = "Use WASD to move. Move to the parchment.";
        chatty.EnterDialogue(speaking);
    }

    public void TutorialTwo()
    {
        speaking = "Collect your first spell, Fire.";
        chatty.EnterDialogue(speaking);
    }

    public void TutorialThree()
    {
        speaking = "You now have the spell Fire. Get to the other side.";
        chatty.EnterDialogue(speaking);
    }

    public void TutorialFour()
    {
        speaking = "Good job! Continue into town and start earning their trust.";
        chatty.EnterDialogue(speaking);
    }
}