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
                seenQuests.Add("-Get Blacksmith iron");
                blacksmithquest1 = true;
            }
        }
        else
        {
            blacksmithquest1 = false;
            if (seenQuests.Contains("-Get Blacksmith iron"))
            { seenQuests.Remove("-Get Blacksmith iron"); }
        }

        if (unlockManager.blacksmithTwoActive == true)
        {
            if (blacksmithquest2 == true)
            { return; }
            else
            {
                seenQuests.Add("-Get Blacksmith Sky-Metal");
                blacksmithquest2 = true;
            }
        }
        else
        {
            blacksmithquest2 = false;
            if (seenQuests.Contains("-Get Blacksmith Sky-Metal"))
            { seenQuests.Remove("-Get Blacksmith Sky-Metal"); }
        }

        if (unlockManager.merchantOneActive == true)
        {
            if (merchantQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find Merchant's Stock List");
                merchantQuest1 = true;
            }
        }
        else
        {
            merchantQuest1 = false;
            if (seenQuests.Contains("-Find Merchant's Stock List"))
            { seenQuests.Remove("-Find Merchant's Stock List"); }
        }

        if (unlockManager.merchantOneActive == true)
        {
            if (merchantQuest2 == true)
            { return; }
            else
            {
                seenQuests.Add("\nFind Merchant's Pencil");
                merchantQuest2 = true;
            }
        }
        else
        {
            merchantQuest2 = false;
            if (seenQuests.Contains("-Find Merchant's Pencil"))
            { seenQuests.Remove("-Find Merchant's Pencil"); }
        }

        if (unlockManager.merchantThreeActive == true)
        {
            if (merchantQuest3 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find Merchant's Ring");
                merchantQuest3 = true;
            }
        }
        else
        {
            merchantQuest3 = false;
            if (seenQuests.Contains("-Find Merchant's Ring"))
            { seenQuests.Remove("-Find Merchant's Ring"); }
        }

        if (unlockManager.townGirlOneActive == true)
        {
            if (townGirlQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find Black & White Fish");
                townGirlQuest1 = true;
            }
        }
        else
        {
            townGirlQuest1 = false;
            if (seenQuests.Contains("-Find Black & White Fish"))
            { seenQuests.Remove("-Find Black & White Fish"); }
        }

        if (unlockManager.townGirlTwoActive == true)
        {
            if (townGirlQuest2 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find Green Gem");
                townGirlQuest2 = true;
            }
        }
        else
        {
            townGirlQuest2 = false;
            if (seenQuests.Contains("-Find Green Gem"))
            { seenQuests.Remove("-Find Green Gem"); }
        }

        if (unlockManager.townGirlThreeActive == true)
        {
            if (townGirlQuest3 == true)
            { return; }
            else
            {
                seenQuests.Add("-Get Wood");
                townGirlQuest3 = true;
            }
        }
        else
        {
            townGirlQuest3 = false;
            if (seenQuests.Contains("-Get Wood"))
            { seenQuests.Remove("-Get Wood"); }
        }

        if (unlockManager.townManOneActive == true)
        {
            if (townMaleQuest1 == true)
            { return; }
            else
            {
                seenQuests.Add("-Find a Dwarf Tool");
                townMaleQuest1 = true;
            }
        }
        else
        {
            townMaleQuest1 = false;
            if (seenQuests.Contains("-Find a Dwarf Tool"))
            { seenQuests.Remove("-Find a Dwarf Tool"); }
        }
        if (unlockManager.townManTwoActive == true)
        {
            if (townMaleQuest2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("-Find Cliff Flower");
                townMaleQuest2 = true;
            } 
        }
        else
        {
            townMaleQuest2 = false;
            if (seenQuests.Contains("-Find Cliff Flower"))
            {
                seenQuests.Remove("-Find Cliff Flower");
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
                seenQuests.Add("-Find a Nut for a Key");
                townCrowQuest1 = true;
            }
        }
        else
        {
            townCrowQuest1 = false;
            if (seenQuests.Contains("-Find a Nut for a Key"))
            {
                seenQuests.Remove("-Find a Nut for a Key");
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
                seenQuests.Add("-Get a lose Rock");
                forestCrowQuest1 = true;
            }
        }
        else
        {
            forestCrowQuest1 = false;
            if (seenQuests.Contains("-Get a lose Rock"))
            {
                seenQuests.Remove("-Get a lose Rock");
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
                seenQuests.Add("-Find Red Gem");
                forestCrowQuest2 = true;
            }
        }
        else
        {
            forestCrowQuest2 = false;
            if (seenQuests.Contains("-Find Red Gem"))
            {
                seenQuests.Remove("-Find Red Gem");
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
                seenQuests.Add("-Have Familiar Spell");
                forestCrowQuest4 = true;
            }
        }
        else
        {
            forestCrowQuest4 = false;
            if (seenQuests.Contains("-Have Familiar Spell"))
            {
                seenQuests.Remove("-Have Familiar Spell");
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
                seenQuests.Add("-Get Bug");
                hecateQuest1 = true;
            }
        }
        else
        {
            hecateQuest1 = false;
            if (seenQuests.Contains("-Get Bug"))
            {
                seenQuests.Remove("-Get Bug");
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
                seenQuests.Add("-Get Cave Carrot");
                hecateQuest2 = true;
            }
        }
        else
        {
            hecateQuest2 = false;
            if (seenQuests.Contains("-Get Cave Carrot"))
            {
                seenQuests.Remove("-Get Cave Carrot");
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
                seenQuests.Add("-Get Seed");
                hecateQuest3 = true;
            }
        }
        else
        {
            hecateQuest3 = false;
            if (seenQuests.Contains("-Get Seed"))
            {
                seenQuests.Remove("-Get Seed");
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
                seenQuests.Add("-Get tiny, bright flower");
                dwarfQuest1 = true;
            }
        }
        else
        {
            dwarfQuest1 = false;
            if (seenQuests.Contains("-Get tiny, bright flower"))
            {
                seenQuests.Remove("-Get tiny, bright flower");
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
                seenQuests.Add("-Get a Nut for a Scroll");
                riverCrowQuest1 = true;
            }
        }
        else
        {
            riverCrowQuest1 = false;
            if (seenQuests.Contains("-Get a Nut for a Scroll"))
            {
                seenQuests.Remove("-Get a Nut for a Scroll");
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
                seenQuests.Add("-Get Cave Flower");
                riverCrowQuest2 = true;
            }
        }
        else
        {
            riverCrowQuest2 = false;
            if (seenQuests.Contains("-Get Cave Flower"))
            {
                seenQuests.Remove("-Get Cave Flower");
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
                seenQuests.Add("-Catch a Golden Carp");
                riverGirlQuest1 = true;
            }
        }
        else
        {
            riverGirlQuest1 = false;
            if (seenQuests.Contains("-Catch a Golden Carp"))
            {
                seenQuests.Remove("-Catch a Golden Carp");
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
                seenQuests.Add("-Catch a Green Fish");
                farmerQuest1 = true;
            }
        }
        else
        {
            farmerQuest1 = false;
            if (seenQuests.Contains("-Catch a Green Fish"))
            {
                seenQuests.Remove("-Catch a Green Fish");
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
                seenQuests.Add("-Catch a Blue Fish");
                farmerQuest2 = true;
            }
        }
        else
        {
            farmerQuest2 = false;
            if (seenQuests.Contains("-Catch a Blue Fish"))
            {
                seenQuests.Remove("-Catch a Blue Fish");
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
                seenQuests.Add("-Catch a Purple Fish");
                farmerQuest3 = true;
            }
        }
        else
        {
            farmerQuest3 = false;
            if (seenQuests.Contains("-Catch a Purple Fish"))
            {
                seenQuests.Remove("-Catch a Purple Fish");
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
                seenQuests.Add("-Catch a Red Fish");
                farmerQuest4 = true;
            }
        }
        else
        {
            farmerQuest4 = false;
            if (seenQuests.Contains("-Catch a Red Fish"))
            {
                seenQuests.Remove("-Catch a Red Fish");
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
                seenQuests.Add("-Catch a Orange Fish");
                farmerQuest5 = true;
            }
        }
        else
        {
            farmerQuest5 = false;
            if (seenQuests.Contains("-Catch a Orange Fish"))
            {
                seenQuests.Remove("-Catch a Orange Fish");
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
                seenQuests.Add("-Catch a Yellow Fish");
                farmerQuest6 = true;
            }
        }
        else
        {
            farmerQuest6 = false;
            if (seenQuests.Contains("-Catch a Yellow Fish"))
            {
                seenQuests.Remove("-Catch a Yellow Fish");
            }
        }

        questBox.text = "Quest List\n" + string.Join("\n", seenQuests);
    }
}
