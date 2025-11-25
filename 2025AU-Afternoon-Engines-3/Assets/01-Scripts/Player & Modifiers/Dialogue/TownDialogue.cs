using UnityEngine;

public class TownDialogue : MonoBehaviour
{
    DialogueChat chatty;
    repTracker repu;
    UnlockManager manager;
    public string speaking;

    // "Standard" refers to dialogue when they have no more quests to give

    public void BlacksmithQuestOne()
    {
        if (manager.blacksmithOneDone = true)
        {
            BlacksmithQuestTwo();
        }
        else if (manager.blacksmithIron = true){
            BlacksmithOneComplete();
        }
        else {
            speaking = "Hey there, chap! Can you got to the caves for me? The dwarfs won't let me in but I need the iron.";
            manager.blacksmithOneActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void BlacksmithOneComplete()
    {
        speaking = "Thanks, chap! Hopefully you didn't have much trouble with the dwarfs.";
        manager.blacksmithOneActive = false;
        manager.blacksmithOneDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void BlacksmithQuestTwo()
    {
        if (manager.blacksmithTwoDone = true)
        {
            BlacksmithStandard();
        }
        else if (manager.blacksmithSkyMetal = true)
        {
            BlacksmithTwoComplete();
        }
        else
        {
            speaking = "Hey again! I'm looking for some sky-metal, but I can't get to the cliffs. Can you get some for me?";
            manager.blacksmithTwoActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void BlacksmithTwoComplete()
    {
        speaking = "Thanks, chap! This should do, at least until I get another commission that requires sky-metal.";
        manager.blacksmithTwoActive = false;
        manager.blacksmithTwoDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void BlacksmithStandard()
    {
        speaking = "Hello, chap! Thanks again for getting those metals for me.";
        chatty.EnterDialogue(speaking);
    }

    public void MerchantQuestOne()
    {
        if (manager.merchantOneDone = true)
        {
            MerchantQuestTwo();
        }
        else if (manager.merchantStockList = true)
        {
            MerchantOneComplete();
        }
        else
        {
            speaking = "Hello, hello valued customer! I'm afraid I've lost my stock book in the forest but the local crows " +
                "are refusing to give it back. Could you, perhaps, help me with that?";
            manager.merchantOneActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void MerchantOneComplete()
    {
        speaking = "Oh, wonderful, wonderful! Thank you so much, valued customer!";
        manager.merchantOneActive = false;
        manager.merchantOneDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void MerchantQuestTwo()
    {
        if (manager.merchantTwoDone = true)
        {
            MerchantQuestThree();
        }
        else if (manager.merchantPencil = true)
        {
            MerchantTwoComplete();
        }
        else
        {
            speaking = "Hello once more, valued customer! Sorry to say but the crows who dance in the ruins have taken " +
                "my only pencil. Perhaps you could convince them to play with some other stick?";
            chatty.EnterDialogue(speaking);
        }
    }

    public void MerchantTwoComplete()
    {
        speaking = "Oh, wondrous, wondrous! Thank you so much, valued customer!";
        manager.merchantTwoActive = false;
        manager.merchantTwoDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void MerchantQuestThree()
    {
        if (manager.merchantThreeDone = true)
        {
            MerchantStandard();
        }
        else if (manager.merchantRing = true)
        {
            MerchantThreeComplete();
        }
        else
        {
            speaking = "Hello hello dear valued customer! I'm afraid that the crows who live in the cliffs have stolen my " +
                "special ring. Could you perhaps help me get it back?";
            manager.merchantThreeActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void MerchantThreeComplete()
    {
        speaking = "Oh joyous day! Thank you oh so very much, valued customer!";
        manager.merchantThreeDone = true;
        manager.merchantThreeActive = false;
        chatty.EnterDialogue(speaking);
    }

    public void MerchantStandard()
    {
        speaking = "Welcome, valued customer!";
        chatty.EnterDialogue(speaking);
    }

    public void FirstGirlQuest()
    {
        if (manager.townGirlOneDone = true)
        {
            FirstGirlStandard();
        }
        else if (manager.townGirlOneFish = true)
        {
            FirstGirlComplete();
        }
        else
        {
            speaking = "Excuse me, ma'am? Could you get me a fish from the river? It's spotted black and white.";
            manager.townGirlOneActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void FirstGirlComplete()
    {
        speaking = "Ah, thank you ma'am. This will work perfectly.";
        manager.townGirlOneActive = false;
        manager.townGirlOneDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void FirstGirlStandard()
    {
        speaking = "Hopefully my husband will enjoy the fish I'm cooking for him.";
        chatty.EnterDialogue(speaking);
    }

    public void SecondGirlQuest()
    {
        if (manager.townGirlTwoDone = true)
        {
            SecondGirlStandard();
        }
        else if (manager.townGirlTwoGem = true)
        {
            SecondGirlComplete();
        }
        else
        {
            speaking = "Hiya! I want to get a gemstone, a green one, from the mines for my brother's birthday but I'm not allowed down " +
                "there. Can you get one for me?";
            manager.townGirlTwoActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void SecondGirlComplete()
    {
        speaking = "Oh hey! Thanks for doing that!";
        manager.townGirlTwoActive = false;
        manager.townGirlTwoDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void SecondGirlStandard()
    {
        speaking = "Did I mention my brother's the local blacksmith? He loves working with gemstones!";
        chatty.EnterDialogue(speaking);
    }

    public void ThirdGirlQuest()
    {
        if (manager.townGirlThreeDone = true)
        {
            ThirdGirlStandard();
        }
        else if (manager.townGirlThreeWood = true)
        {
            ThirdGirlComplete();
        }
        else
        {
            speaking = "Pardon, can you retrieve some wood for the forest for me?";
            manager.townGirlThreeActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void ThirdGirlComplete()
    {
        speaking = "So you're more reliable than my excuse of a husband. Thanks.";
        manager.townGirlThreeActive = false;
        manager.townGirlThreeDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void ThirdGirlStandard()
    {
        speaking = "What in the world is my husband up to now?";
        chatty.EnterDialogue(speaking);
    }

    public void FirstManQuest()
    {
        if (manager.townManOneDone = true)
        {
            FirstManStandard();
        }
        else if (manager.townManOneDwarfTool = true)
        {
            FirstManComplete();
        }
        else
        {
            speaking = "Have you seen a dwarf before? Can you bring me proof?";
            manager.townManOneActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void FirstManComplete()
    {
        speaking = "Oh wow! I real dwarf item! Thank you so much for showing me!";
        manager.townManOneActive = false;
        manager.townManOneDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void FirstManStandard()
    {
        speaking = "The blacksmith keeps complaining about the dwarfs, but I want to learn more about them,";
        chatty.EnterDialogue(speaking);
    }

    public void SecondManQuest()
    {
        if (manager.townManTwoDone = true)
        {
            SecondManStandard();
        }
        else if (manager.townManTwoFlowerCliff = true)
        {
            SecondManComplete();
        }
        else
        {
            speaking = "There's a beautiful flower up in the cliffs I wish to give to my wife. Could you help me with that?";
            manager.townManTwoActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void SecondManComplete()
    {
        speaking = "Oh! The flower is more beautiful than I imagined! Thank you so much!";
        manager.townManTwoActive = false;
        manager.townManTwoDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void SecondManStandard()
    {
        speaking = "My wife always complains about how scatterbrained I am.";
        chatty.EnterDialogue(speaking);
    }

    public void CrowLikesKeyQuest()
    {
        if (manager.crowKeyDone = true)
        {
            CrowLikesKeyStandard();
        }
        else if (manager.crowKeyNut = true)
        {
            CrowLikesKeyComplete();
        }
        else
        {
            speaking = "Caw! Does friend have nut? Me give key!";
            manager.crowKeyActive = true;
            chatty.EnterDialogue(speaking);
        }
    }

    public void CrowLikesKeyComplete()
    {
        speaking = "Caw! Me likes nut! Key key!";
        manager.crowKeyActive = false;
        manager.crowKeyDone = true;
        chatty.EnterDialogue(speaking);
    }

    public void CrowLikesKeyStandard()
    {
        speaking = "Caw caw! Me like nut! Squawk!";
        chatty.EnterDialogue(speaking);
    }
}
