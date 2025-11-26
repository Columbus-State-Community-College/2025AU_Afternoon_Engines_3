using UnityEngine;

public class CaveDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    UnlockManager manager;
    QuestList questy;
    public string speaking;

    public void DwarfOneStandard()
    {
        speaking = "Hahahahaha... Hibbabibabi stuck in hole!";
        chatty.EnterDialogue(speaking);
    }

    public void DwarfTwoStandard()
    {
        speaking = "Hakkikakika think Hibbabibabi in hole funny. Hiyyayiyayi no find funny.";
        chatty.EnterDialogue(speaking);
    }

    public void DwarfThreeQuest()
    {
        if (manager.dwarfDone = true)
        {
            DwarfThreeStandard();
        }
        else if (manager.dwarfFlower = true)
        {
            DwarfThreeComplete();
        }
        else
        {
            speaking = "Hiqqaqiqaqi want flower. Tall person bring flower? Hiqqaqiqaqi want tiny bright flower.";
            manager.dwarfActive = true;
            questy.whatQuestSeen();
            chatty.EnterDialogue(speaking);
        }
    }

    public void DwarfThreeComplete()
    {
        speaking = "Tall person bring flower! Hiqqaqiqaqi happy!";
        manager.dwarfActive = false;
        manager.dwarfDone = true;
        questy.whatQuestSeen();
        chatty.EnterDialogue(speaking);
    }

    public void DwarfThreeStandard()
    {
        speaking = "Hiqqaqiqaqi think Hakkikakika, Hibbabibabi, and Hiyyayiyayi stupid.";
        chatty.EnterDialogue(speaking);
    }
}
