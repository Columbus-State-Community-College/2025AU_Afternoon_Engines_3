using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class QuestList : MonoBehaviour
{
    public TextMeshProUGUI questBox;
    public UnlockManager unlockManager;
    public List<string> seenQuests = new List<string>();
    bool blacksmithquest1, blacksmithquest2,
    merchantQuest1, merchantQuest2, merchantQuest3,
    townGirlQuest1, townGirlQuest2, townGirlQuest3,
    townMaleQuest1, townMaleQuest2, townCrowQuest1,
    forestCrowQuest1, forestCrowQuest2, forestCrowQuest3, forestCrowQuest4,
    hecateQuest1, hecateQuest2, hecateQuest3,
    dwarfQuest1,
    riverCrowQuest1, riverCrowQuest2, riverGirlQuest1,
    farmerQuest1, farmerQuest2, farmerQuest3, farmerQuest4, farmerQuest5, farmerQuest6;

    [HideInInspector] public static QuestList instance;

    void Start()
    {
        if(instance == null)
        {instance = this;}
        else
        {if(instance != this)
        {Destroy(gameObject);}}
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
    public void whatQuestSeen()
    {
        if (unlockManager.blacksmithOneActive == true)
        {
            if (blacksmithquest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Get the Blacksmith some iron");
                blacksmithquest1 = true;
            }
        }
        else
        {
            blacksmithquest1 = false;
            if (seenQuests.Contains("-Get the Blacksmith some iron"))
            { seenQuests.Remove("-Get the Blacksmith some iron"); }
        }

        if (unlockManager.blacksmithTwoActive == true)
        {
            if (blacksmithquest2 == true)
            { return; }
            else
            {
                seenQuests.Add("-Get the Blacksmith some Sky-Metal");
                blacksmithquest2 = true;
            }
        }
        else
        {
            blacksmithquest2 = false;
            if (seenQuests.Contains("-Get the Blacksmith some Sky-Metal"))
            { seenQuests.Remove("-Get the Blacksmith some Sky-Metal"); }
        }

        if (unlockManager.merchantOneActive == true)
        {
            if (merchantQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find the Merchant's lost Stock List");
                merchantQuest1 = true;
            }
        }
        else
        {
            merchantQuest1 = false;
            if (seenQuests.Contains("-Find the Merchant's lost Stock List"))
            { seenQuests.Remove("-Find the Merchant's lost Stock List"); }
        }

        if (unlockManager.merchantOneActive == true)
        {
            if (merchantQuest2 == true)
            { return; }
            else
            {
                seenQuests.Add("\nFind the Merchant's lost Pencil");
                merchantQuest2 = true;
            }
        }
        else
        {
            merchantQuest2 = false;
            if (seenQuests.Contains("-Find the Merchant's lost Pencil"))
            { seenQuests.Remove("-Find the Merchant's lost Pencil"); }
        }

        if (unlockManager.merchantThreeActive == true)
        {
            if (merchantQuest3 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find the Merchant's lost Ring");
                merchantQuest3 = true;
            }
        }
        else
        {
            merchantQuest3 = false;
            if (seenQuests.Contains("-Find the Merchant's lost Ring"))
            { seenQuests.Remove("-Find the Merchant's lost Ring"); }
        }

        if (unlockManager.townGirlOneActive == true)
        {
            if (townGirlQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find a Black & White Fish for a villager");
                townGirlQuest1 = true;
            }
        }
        else
        {
            townGirlQuest1 = false;
            if (seenQuests.Contains("-Find a Black & White Fish for a villager"))
            { seenQuests.Remove("-Find a Black & White Fish for a villager"); }
        }

        if (unlockManager.townGirlTwoActive == true)
        {
            if (townGirlQuest2 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find a Green Gem for a villager");
                townGirlQuest2 = true;
            }
        }
        else
        {
            townGirlQuest2 = false;
            if (seenQuests.Contains("-Find a Green Gem for a villager"))
            { seenQuests.Remove("-Find a Green Gem for a villager"); }
        }

        if (unlockManager.townGirlThreeActive == true)
        {
            if (townGirlQuest3 == true)
            { return; }
            else
            {
                seenQuests.Add("-Get some Wood for a villager");
                townGirlQuest3 = true;
            }
        }
        else
        {
            townGirlQuest3 = false;
            if (seenQuests.Contains("-Get some Wood for a villager"))
            { seenQuests.Remove("-Get some Wood for a villager"); }
        }

        if (unlockManager.townManOneActive == true)
        {
            if (townMaleQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find a Dwarf Tool for a villager");
                townMaleQuest1 = true;
            }
        }
        else
        {
            townMaleQuest1 = false;
            if (seenQuests.Contains("-Find a Dwarf Tool for a villager"))
            { seenQuests.Remove("-Find a Dwarf Tool for a villager"); }
        }
        if (unlockManager.townManTwoActive == true)
        {
            if (townMaleQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Find a Cliff Flower for a villager");
                townMaleQuest2 = true;
            } 
        }
        else
        {
            townMaleQuest2 = false;
            if (seenQuests.Contains("-Find a Cliff Flower for a villager"))
            {
                seenQuests.Remove("-Find a Cliff Flower for a villager");
            }
        }

        if (unlockManager.crowKeyActive == true)
        {
            if (townCrowQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Find a Nut to trade for a Key");
                townCrowQuest1 = true;
            }
        }
        else
        {
            townCrowQuest1 = false;
            if (seenQuests.Contains("-Find a Nut to trade for a Key"))
            {
                seenQuests.Remove("-Find a Nut to trade for a Key");
            }
        }

        if (unlockManager.crowOneActive == true)
        {
            if (forestCrowQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a lose Rock for the crow");
                forestCrowQuest1 = true;
            }
        }
        else
        {
            forestCrowQuest1 = false;
            if (seenQuests.Contains("-Get a lose Rock for the crow"))
            {
                seenQuests.Remove("-Get a lose Rock for the crow");
            }
        }

        if (unlockManager.crowTwoActive == true)
        {
            if (forestCrowQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Find a Red Gem for the crow");
                forestCrowQuest2 = true;
            }
        }
        else
        {
            forestCrowQuest2 = false;
            if (seenQuests.Contains("-Find a Red Gem for the crow"))
            {
                seenQuests.Remove("-Find a Red Gem for the crow");
            }
        }

        if (unlockManager.crowThreeActive == true)
        {
            if (forestCrowQuest3 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Speak to Hecate");
                forestCrowQuest3 = true;
            }
        }
        else
        {
            forestCrowQuest3 = false;
            if (seenQuests.Contains("-Speak to Hecate"))
            {
                seenQuests.Remove("-Speak to Hecate");
            }
        }

        if (unlockManager.crowFourActive == true)
        {
            if (forestCrowQuest4 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Have the Familiar Spell");
                forestCrowQuest4 = true;
            }
        }
        else
        {
            forestCrowQuest4 = false;
            if (seenQuests.Contains("-Have the Familiar Spell"))
            {
                seenQuests.Remove("-Have the Familiar Spell");
            }
        }

        if (unlockManager.hecateOneActive == true)
        {
            if (hecateQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a Bug for Hecate");
                hecateQuest1 = true;
            }
        }
        else
        {
            hecateQuest1 = false;
            if (seenQuests.Contains("-Get a Bug for Hecate"))
            {
                seenQuests.Remove("-Get a Bug for Hecate");
            }
        }

        if (unlockManager.hecateTwoActive == true)
        {
            if (hecateQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a Cave Carrot for Hecate");
                hecateQuest2 = true;
            }
        }
        else
        {
            hecateQuest2 = false;
            if (seenQuests.Contains("-Get a Cave Carrot for Hecate"))
            {
                seenQuests.Remove("-Get a Cave Carrot for Hecate");
            }
        }

        if (unlockManager.hecateThreeActive == true)
        {
            if (hecateQuest3 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a Tree Seed for Hecate");
                hecateQuest3 = true;
            }
        }
        else
        {
            hecateQuest3 = false;
            if (seenQuests.Contains("-Get a Tree Seed for Hecate"))
            {
                seenQuests.Remove("-Get a Tree Seed for Hecate");
            }
        }

        if (unlockManager.dwarfActive == true)
        {
            if (dwarfQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get tiny, bright flower for the dwarf");
                dwarfQuest1 = true;
            }
        }
        else
        {
            dwarfQuest1 = false;
            if (seenQuests.Contains("-Get tiny, bright flower for the dwarf"))
            {
                seenQuests.Remove("-Get tiny, bright flower for the dwarf");
            }
        }

        if (unlockManager.riverCrowOneActive == true)
        {
            if (riverCrowQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a Nut to trade for a Scroll");
                riverCrowQuest1 = true;
            }
        }
        else
        {
            riverCrowQuest1 = false;
            if (seenQuests.Contains("-Get a Nut to trade for a Scroll"))
            {
                seenQuests.Remove("-Get a Nut to trade for a Scroll");
            }
        }

        if (unlockManager.riverCrowTwoActive == true)
        {
            if (riverCrowQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Get a Cave Flower for a crow at the river");
                riverCrowQuest2 = true;
            }
        }
        else
        {
            riverCrowQuest2 = false;
            if (seenQuests.Contains("-Get a Cave Flower for a crow at the river"))
            {
                seenQuests.Remove("-Get a Cave Flower for a crow at the river");
            }
        }

        if (unlockManager.riverGirlActive == true)
        {
            if (riverGirlQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Golden Carp for the girl at the river");
                riverGirlQuest1 = true;
            }
        }
        else
        {
            riverGirlQuest1 = false;
            if (seenQuests.Contains("-Catch a Golden Carp for the girl at the river"))
            {
                seenQuests.Remove("-Catch a Golden Carp for the girl at the river");
            }
        }

        if (unlockManager.farmerOneActive == true)
        {
            if (farmerQuest1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Green Fish for the farmer");
                farmerQuest1 = true;
            }
        }
        else
        {
            farmerQuest1 = false;
            if (seenQuests.Contains("-Catch a Green Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Green Fish for the farmer");
            }
        }

        if (unlockManager.farmerTwoActive == true)
        {
            if (farmerQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Blue Fish for the farmer");
                farmerQuest2 = true;
            }
        }
        else
        {
            farmerQuest2 = false;
            if (seenQuests.Contains("-Catch a Blue Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Blue Fish for the farmer");
            }
        }

        if (unlockManager.farmerThreeActive == true)
        {
            if (farmerQuest3 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Purple Fish for the farmer");
                farmerQuest3 = true;
            }
        }
        else
        {
            farmerQuest3 = false;
            if (seenQuests.Contains("-Catch a Purple Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Purple Fish for the farmer");
            }
        }

        if (unlockManager.farmerFourActive == true)
        {
            if (farmerQuest4 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Red Fish for the farmer");
                farmerQuest4 = true;
            }
        }
        else
        {
            farmerQuest4 = false;
            if (seenQuests.Contains("-Catch a Red Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Red Fish for the farmer");
            }
        }

        if (unlockManager.farmerFiveActive == true)
        {
            if (farmerQuest5 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Orange Fish for the farmer");
                farmerQuest5 = true;
            }
        }
        else
        {
            farmerQuest5 = false;
            if (seenQuests.Contains("-Catch a Orange Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Orange Fish for the farmer");
            }
        }

        if (unlockManager.farmerSixActive == true)
        {
            if (farmerQuest6 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Catch a Yellow Fish for the farmer");
                farmerQuest6 = true;
            }
        }
        else
        {
            farmerQuest6 = false;
            if (seenQuests.Contains("-Catch a Yellow Fish for the farmer"))
            {
                seenQuests.Remove("-Catch a Yellow Fish for the farmer");
            }
        }

        questBox.text = "Quest List\n" + string.Join("\n", seenQuests);
    }
}
