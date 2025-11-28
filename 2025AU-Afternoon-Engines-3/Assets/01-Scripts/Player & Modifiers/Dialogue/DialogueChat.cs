using UnityEngine;
using TMPro;

public class DialogueChat : MonoBehaviour
{
    public GameObject dialogueBox; // This is the UI box where the dialogue will appear
    public TextMeshProUGUI textBoxName;
    public TextMeshProUGUI textBoxText;
    
    public TutorialDialogue tutorial;
    public TownDialogue town;
    public MushroomDialogue mushroom;
    public RiverDialogue river;
    public CaveDialogue cave;
    [HideInInspector] public static DialogueChat instance;

    void Start()
    {
        dialogueBox.SetActive(false);
        if(instance == null)
        {instance = this;}
        else
        {if(instance != this)
        {Destroy(gameObject);}}
    }

    public void NoMoreDialogue()
    {
        Debug.Log("NoMoreDialogue()");
        dialogueBox.SetActive(false);
        textBoxName.text = "";
        textBoxText.text = "";
    }

    public void ActiveDialogue()
    {
        Debug.Log("ActiveDiallogue()");
        dialogueBox.SetActive(true);
    }

    public void EnterDialogue(string NPCName, string dialogue)
    {
        Debug.Log($"EnterDialogue(): {NPCName}, {dialogue}");
        textBoxName.text = NPCName;
        textBoxText.text = dialogue;
    }

    // This will be expanded and edited as specific NPCs are added.
    // The current two tags are test tags we can change out.
    // It is the same with the functions they point to, their contents will be changed.
    public void GetDialogue(string thisNPC)
    {
        if (thisNPC == "nullPlaceholder")
        {
            string placeholderDialogue = "This NPC does not have an attached NPCName in the isEmmaNear script, please check the scripting or report as a bug if you encounter this.";
            EnterDialogue("nullPlaceholder", placeholderDialogue);
            ActiveDialogue();
        }
        if (thisNPC == "Blacksmith") // Blacksmith
        {
            town.BlacksmithQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "Merchant") // Merchant
        {
            town.MerchantQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Girl One") // townGirlOne
        {
            town.FirstGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Girl Two") // townGirlTwo
        {
            town.SecondGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Girl Three") // townGirlThree
        {
            town.ThirdGirlQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Man One")
        {
            town.FirstManQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Man Two")
        {
            town.SecondManQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Town Crow")
        {
            town.CrowLikesKeyQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Forest Crow One")
        {
            mushroom.crowOneQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Forest Crow Two")
        {
            mushroom.crowTwoQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Forest Crow Three")
        {
            mushroom.crowThreeQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Forest Crow Four")
        {
            mushroom.crowFourQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Hecate")
        {
            mushroom.HecateQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "River Crow One")
        {
            river.CrowOneQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "River Crow Two")
        {
            river.CrowTwoQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "River Girl")
        {
            river.FemaleQuest();
            ActiveDialogue();
        }
        else if (thisNPC == "Farmer")
        {
            river.FarmerQuestOne();
            ActiveDialogue();
        }
        else if (thisNPC == "Dwarf One")
        {
            cave.DwarfOneStandard();
            ActiveDialogue();
        }
        else if (thisNPC == "Dwarf Two")
        {
            cave.DwarfTwoStandard();
            ActiveDialogue();
        }
        else if (thisNPC == "Dwarf Three")
        {
            cave.DwarfThreeQuest();
            ActiveDialogue();
        }
    }
}