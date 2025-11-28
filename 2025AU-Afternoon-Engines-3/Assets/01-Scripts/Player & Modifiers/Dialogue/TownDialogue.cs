using UnityEngine;

public class TownDialogue : MonoBehaviour
{
    public DialogueChat dialogueChatScript;
    public repTracker reputationTracker;
    public UnlockManager unlockManager;
    public QuestList questList;
    public string NPCName;
    public string dialogue;

    // "Standard" refers to dialogue when they have no more quests to give
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

    public void BlacksmithQuestOne()
    {
        if (unlockManager.blacksmithOneDone == true)
        {
            BlacksmithQuestTwo();
        }
        else if (unlockManager.blacksmithIron == true)
        {
            BlacksmithOneComplete();
        }
        else
        {
            NPCName = "Blacksmith";
            dialogue = "Hey there, chap! Can you go to the caves for me? The dwarves won't let me in but I need the iron.";
            unlockManager.blacksmithOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void BlacksmithOneComplete()
    {
        NPCName = "Blacksmith";
        dialogue = "Thanks, chap! Hopefully you didn't have much trouble with the dwarves.";
        unlockManager.blacksmithOneActive = false;
        unlockManager.blacksmithOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void BlacksmithQuestTwo()
    {
        if (unlockManager.blacksmithTwoDone == true)
        {
            BlacksmithStandard();
        }
        else if (unlockManager.blacksmithSkyMetal == true)
        {
            BlacksmithTwoComplete();
        }
        else
        {
            dialogue = "Hey again! I'm looking for some sky-metal, but I can't get to the cliffs. Can you get some for me?";
            unlockManager.blacksmithTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void BlacksmithTwoComplete()
    {
        dialogue = "Thanks, chap! This should do, at least until I get another commission that requires sky-metal.";
        unlockManager.blacksmithTwoActive = false;
        unlockManager.blacksmithTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void BlacksmithStandard()
    {
        dialogue = "Hello, chap! Thanks again for getting those metals for me.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void MerchantQuestOne()
    {
        if (unlockManager.merchantOneDone == true)
        {
            MerchantQuestTwo();
        }
        else if (unlockManager.merchantStockList == true)
        {
            MerchantOneComplete();
        }
        else
        {
            NPCName = "Doyle the Merchant";
            dialogue = "Hello, hello valued customer! I'm afraid I've lost my stock book in the forest but the local crowsare refusing to give it back. Could you, perhaps, help me with that?";
            unlockManager.merchantOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void MerchantOneComplete()
    {
        NPCName = "Doyle the Merchant";
        dialogue = "Oh, wonderful, wonderful! Thank you so much, valued customer!";
        unlockManager.merchantOneActive = false;
        unlockManager.merchantOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void MerchantQuestTwo()
    {
        if (unlockManager.merchantTwoDone == true)
        {
            MerchantQuestThree();
        }
        else if (unlockManager.merchantPencil == true)
        {
            MerchantTwoComplete();
        }
        else
        {
            NPCName = "Doyle the Merchant";
            dialogue = "Hello once more, valued customer! Sorry to say but the crows who dance in the ruins have takenmy only pencil. Perhaps you could convince them to play with some other stick?";
            unlockManager.merchantTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void MerchantTwoComplete()
    {
        NPCName = "Doyle the Merchant";
        dialogue = "Oh, wondrous, wondrous! Thank you so much, valued customer!";
        unlockManager.merchantTwoActive = false;
        unlockManager.merchantTwoDone = true;
        questList.whatQuestSeen();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void MerchantQuestThree()
    {
        if (unlockManager.merchantThreeDone == true)
        {
            MerchantStandard();
        }
        else if (unlockManager.merchantRing == true)
        {
            MerchantThreeComplete();
        }
        else
        {
            NPCName = "Doyle the Merchant";
            dialogue = "Hello hello dear valued customer! I'm afraid that the crows who live in the cliffs have stolen my special ring. Could you perhaps help me get it back?";
            unlockManager.merchantThreeActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void MerchantThreeComplete()
    {
        NPCName = "Doyle the Merchant";
        dialogue = "Oh, that makes my day! Thank you oh so very much, valued customer!";
        unlockManager.merchantThreeDone = true;
        unlockManager.merchantThreeActive = false;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void MerchantStandard()
    {
        NPCName = "Doyle the Merchant";
        dialogue = "Thank you for the hard work you've put in, thinking about getting some posters up one of these days to commemorate you!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FirstGirlQuest()
    {
        if (unlockManager.townGirlOneDone == true)
        {
            FirstGirlStandard();
        }
        else if (unlockManager.townGirlOneFish == true)
        {
            FirstGirlComplete();
        }
        else
        {
            NPCName = "Floran";
            dialogue = "Excuse me, ma'am? Could you get me a fish from the river? It's spotted black and white.";
            unlockManager.townGirlOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FirstGirlComplete()
    {
        NPCName = "Floran";
        dialogue = "Ah, thank you ma'am. This will work perfectly.";
        unlockManager.townGirlOneActive = false;
        unlockManager.townGirlOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FirstGirlStandard()
    {
        NPCName = "Floran";
        dialogue = "Hopefully my husband will enjoy the fish I'm cooking for him.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void SecondGirlQuest()
    {
        if (unlockManager.townGirlTwoDone == true)
        {
            SecondGirlStandard();
        }
        else if (unlockManager.townGirlTwoGem == true)
        {
            SecondGirlComplete();
        }
        else
        {
            NPCName = "Quill";
            dialogue = "Hiya! I want to get a gemstone, a green one, from the mines for my brother's birthday but I'm not allowed down there. Can you get one for me?";
            unlockManager.townGirlTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void SecondGirlComplete()
    {
        NPCName = "Quill";
        dialogue = "Oh hey! Thanks for doing that!";
        unlockManager.townGirlTwoActive = false;
        unlockManager.townGirlTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void SecondGirlStandard()
    {
        NPCName = "Quill";
        dialogue = "Did I mention my brother's the local blacksmith? He loves working with gemstones!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void ThirdGirlQuest()
    {
        if (unlockManager.townGirlThreeDone == true)
        {
            ThirdGirlStandard();
        }
        else if (unlockManager.townGirlThreeWood == true)
        {
            ThirdGirlComplete();
        }
        else
        {
            NPCName = "Samantha";
            dialogue = "Pardon, can you retrieve some wood for the forest for me?";
            unlockManager.townGirlThreeActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void ThirdGirlComplete()
    {
        NPCName = "Samantha";
        dialogue = "So you're more reliable than my excuse of a husband. Thanks.";
        unlockManager.townGirlThreeActive = false;
        unlockManager.townGirlThreeDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void ThirdGirlStandard()
    {
        NPCName = "Samantha";
        dialogue = "What in the world is my husband up to now?";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FirstManQuest()
    {
        if (unlockManager.townManOneDone == true)
        {
            FirstManStandard();
        }
        else if (unlockManager.townManOneDwarfTool == true)
        {
            FirstManComplete();
        }
        else
        {
            NPCName = "Bron";
            dialogue = "Have you seen a dwarf before? Can you bring me proof?";
            unlockManager.townManOneActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void FirstManComplete()
    {
        NPCName = "Bron";
        dialogue = "Oh wow! A real dwarf item! Thank you so much for showing me!";
        unlockManager.townManOneActive = false;
        unlockManager.townManOneDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void FirstManStandard()
    {
        NPCName = "Bron";
        dialogue = "The blacksmith keeps complaining about the dwarves, but I want to learn more about them. Not sure why they keep calling me Bronze.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void SecondManQuest()
    {
        if (unlockManager.townManTwoDone == true)
        {
            SecondManStandard();
        }
        else if (unlockManager.townManTwoFlowerCliff == true)
        {
            SecondManComplete();
        }
        else
        {
            NPCName = "Alan";
            dialogue = "There's a beautiful flower up in the cliffs I wish to give to my wife. Could you help me with that?";
            unlockManager.townManTwoActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void SecondManComplete()
    {
        NPCName = "Alan";
        dialogue = "Oh! The flower is more beautiful than I imagined! Thank you so much!";
        unlockManager.townManTwoActive = false;
        unlockManager.townManTwoDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void SecondManStandard()
    {
        NPCName = "Alan";
        dialogue = "My wife always complains about how scatterbrained I am.";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowLikesKeyQuest()
    {
        if (unlockManager.crowKeyDone == true)
        {
            CrowLikesKeyStandard();
        }
        else if (unlockManager.crowKeyNut == true)
        {
            CrowLikesKeyComplete();
        }
        else
        {
            NPCName = "Kaw";
            dialogue = "Caw! Does friend have nut? Me give key!";
            unlockManager.crowKeyActive = true;
            questList.whatQuestSeen();
            dialogueChatScript.EnterDialogue(NPCName, dialogue);
        }
    }

    public void CrowLikesKeyComplete()
    {
        NPCName = "Kaw";
        dialogue = "Caw! Me likes nut! Key key!";
        unlockManager.crowKeyActive = false;
        unlockManager.crowKeyDone = true;
        questList.whatQuestSeen();
        reputationTracker.GetRep();
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }

    public void CrowLikesKeyStandard()
    {
        NPCName = "Kaw";
        dialogue = "Caw caw! Me like nut! Squawk!";
        dialogueChatScript.EnterDialogue(NPCName, dialogue);
    }
}
