using UnityEngine;
using TMPro;

public class DialogueChat : MonoBehaviour
{
    public TextMeshProUGUI dialogueBox; // This is the UI box where the dialogue will appear
    TutorialDialogue tutorial;
    TownDialogue town;
    MushroomDialogue mushroom;
    RiverDialogue river;
    CaveDialogue cave;
    [HideInInspector] public static DialogueChat instance;

    void Start()
    {
        dialogueBox.gameObject.SetActive(false);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void NoMoreDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    public void ActiveDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
    }

    public void EnterDialogue(string chatter)
    {
        dialogueBox.text = chatter;
    }

    // This will be expanded and edited as specific NPCs are added.
    // The current two tags are test tags we can change out.
    // It is the same with the functions they point to, their contents will be changed.
    public void GetDialogue(string thisNPC)
    {
        if (thisNPC == "blacksmith")
        {
            town.BlacksmithQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "merchant")
        {
            town.MerchantQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "townGirlOne")
        {
            town.FirstGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "townGirlTwo")
        {
            town.SecondGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "townGirlThree")
        {
            town.ThirdGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "townManOne")
        {
            town.FirstManQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "townManTwo")
        {
            town.SecondManQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "townCrow")
        {
            town.CrowLikesKeyQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "forestCrowOne")
        {
            mushroom.crowOneQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "forestCrowTwo")
        {
            mushroom.crowTwoQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "forestCrowThree")
        {
            mushroom.crowThreeQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "forestCrowFour")
        {
            mushroom.crowFourQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "hecate")
        {
            mushroom.HecateQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "riverCrowOne")
        {
            river.CrowOneQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "riverCrowTwo")
        {
            river.CrowTwoQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "riverGirl")
        {
            river.FemaleQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "farmer")
        {
            river.FarmerQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "dwarfOne")
        {
            cave.DwarfOneStandard();
            ActiveDialogue();
        }
        else if (thisNPC == "dwarfTwo")
        {
            cave.DwarfTwoStandard();
            ActiveDialogue();
        }
        else if (thisNPC == "dwarfThree")
        {
            cave.DwarfThreeQuest();
            ActiveDialogue();
        }
    }
}
