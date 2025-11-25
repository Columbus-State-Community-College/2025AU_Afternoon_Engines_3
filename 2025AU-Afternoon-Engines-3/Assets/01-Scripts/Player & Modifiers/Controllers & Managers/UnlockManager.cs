using UnityEngine;

public class UnlockManager : MonoBehaviour
{
    public static UnlockManager instance;
    public bool gameMenuOpen, dialogueActive;
    [Header("T1 Unlocks")]
    public bool parchment3x3;
    public bool fireSpellUnlocked, speedSpellUnlocked, electricitySpellUnlocked, spectralArrowSpellUnlocked, rockSpellUnlocked, healSpellUnlocked, debugSpellUnlocked, dispelPersonalSpellUnlocked;

    [Header("T2 Unlocks")]
    public bool parchment5x5;
    public bool fishingSpellUnlocked, freezeSpellUnlocked, windSpellUnlocked, boulderSpellUnlocked, gravitySpellUnlocked, explosionSpellUnlocked, thunderSpellUnlocked, unlockSpellUnlocked, verdantSpellUnlocked, dispelOtherSpellUnlocked;

    [Header("T3 Unlocks")]
    public bool parchment7x7;
    public bool floodSpellUnlocked, decurseSpellUnlocked, flightSpellUnlocked, intangibilitySpellUnlocked, charmSpellUnlocked, launchSpellUnlocked, familiarSpellUnlocked, enchantSpellUnlocked, theFinalSpellUnlocked;

    [Header("Quest Items")]
    public bool blacksmithIron, blacksmithSkyMetal, merchantStockList, merchantPencil, merchantRing, towmGirlOneFish, townGirlTwoGem, townGirlThreeWood, townManOneDwarfTool, townManTwoFlowerCliff, crowKeyNut;
    public bool crowOneRock, crowTwoSmithGift, crowThreeTalkToHecate, crowFourWolfScary, hecateOneBug, hecateTwoCarrot, hecateThreeSeed;
    public bool dwarfThreeFlower, riverCrowOneNut, riverCrowTwoFlower, riverGirlGoldCarp, farmerGreenFish, farmerBlueFish, farmerPurpleFish, farmerRedFish, farmerOrangeFish, farmerYellowFish;

    [Header("Is Quest Active")]
    public bool blacksmithOneActive, blacksmithTwoActive, merchantOneActive, merchantTwoActive, merchantThreeActive, townGirlOneActive, townGirlTwoActive, townGirlThreeActive, townManOneActive, townManTwoActive, crowKeyActive;
    public bool crowOneActive, crowTwoActive, crowThreeActive, crowFourActive, hecateOneActive, hecateTwoActive, hecateThreeActive;
    public bool dwarfActive, riverCrowOneActive, riverCrowTwoActive, riverGirlActive, farmerOneActive, farmerTwoActive, farmerThreeActive, farmerFourActive, farmerFiveActive, farmerSixActive;

    [Header("Is QuestDone")]
    public bool blacksmithOneDone, blacksmithTwoDone, merchantOneDone, merchantTwoDone, merchantThreeDone, townGirlOneDone, townGirlTwoDone, townGirlThreeDone, townManOneDone, townManTwoDone, crowKeyDone;
    public bool crowOneDone, crowTwoDone, crowThreeDone, crowFourDone, hecateOneDone, hecateTwoDone, hecateThreeDone;
    public bool dwarfDone, riverCrowOneDone, riverCrowTwoDone, riverGirlDone, farmerOneDone, farmerTwoDone, farmerThreeDone, farmerFourDone, farmerFiveDone, farmerSixDone;




    void Start()
    {
        if(instance == null)
        {instance = this;}
        else
        {if(instance != this)
        {Destroy(gameObject);}}
        DontDestroyOnLoad(gameObject);
    }
}
 