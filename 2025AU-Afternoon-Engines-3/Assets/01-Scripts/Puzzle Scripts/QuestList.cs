using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class QuestList : MonoBehaviour
{
    public TextMeshProUGUI questBox;
    UnlockManager manager;
    public List<string> seenQuests = new List<string>();
    bool bs1, bs2, m1, m2, m3, tg1, tg2, tg3, tm1, tm2, tc1, fc1, fc2, fc3, fc4, h1, h2, h3, d1, rc1, rc2, rg1, f1, f2, f3, f4, f5, f6;

    [HideInInspector] public static QuestList instance;

    void Start()
    {
        questBox.gameObject.SetActive(false);
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

    public void whatQuestSeen()
    {
        if (manager.blacksmithOneActive == true)
        {
            if (bs1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Blacksmith iron");
                bs1 = true;
            }
        }
        else
        {
            bs1 = false;
            if (seenQuests.Contains("\n-Get Blacksmith iron"))
            {
                seenQuests.Remove("\n-Get Blacksmith iron");
            }
        }

        if (manager.blacksmithTwoActive == true)
        {
            if (bs2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Blacksmith Sky-Metal");
                bs2 = true;
            }
        }
        else
        {
            bs2 = false;
            if (seenQuests.Contains("\n-Get Blacksmith Sky-Metal"))
            {
                seenQuests.Remove("\n-Get Blacksmith Sky-Metal");
            }
        }

        if (manager.merchantOneActive == true)
        {
            if (m1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Merchant's Stock List");
                m1 = true;
            }
        }
        else
        {
            m1 = false;
            if (seenQuests.Contains("\n-Find Merchant's Stock List")) {
                seenQuests.Remove("\n-Find Merchant's Stock List");
            }
        }

        if (manager.merchantOneActive == true)
        {
            if (m2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\nFind Merchant's Pencil");
                m2 = true;
            }
        }
        else
        {
            m2 = false;
            if (seenQuests.Contains("\n-Find Merchant's Pencil"))
            {
                seenQuests.Remove("\n-Find Merchant's Pencil");
            }
        }

        if (manager.merchantThreeActive == true)
        {
            if (m3 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Merchant's Ring");
                m3 = true;
            }
        }
        else
        {
            m3 = false;
            if (seenQuests.Contains("\n-Find Merchant's Ring"))
            {
                seenQuests.Remove("\n-Find Merchant's Ring");
            }
        }

        if (manager.townGirlOneActive == true)
        {
            if (tg1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Black & White Fish");
                tg1 = true;
            }
        }
        else
        {
            tg1 = false;
            if (seenQuests.Contains("\n-Find Black & White Fish"))
            {
                seenQuests.Remove("\n-Find Black & White Fish");
            }
        }

        if (manager.townGirlTwoActive == true)
        {
            if (tg2 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Green Gem");
                tg2 = true;
            }
        }
        else
        {
            tg2 = false;
            if (seenQuests.Contains("\n-Find Green Gem"))
            {
                seenQuests.Remove("\n-Find Green Gem");
            }
        }

        if (manager.townGirlThreeActive == true)
        {
            if (tg3 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Wood");
                tg3 = true;
            }
        }
        else
        {
            tg3 = false;
            if (seenQuests.Contains("\n-Get Wood"))
            {
                seenQuests.Remove("\n-Get Wood");
            }
        }

        if (manager.townManOneActive == true)
        {
            if (tm1 == true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find a Dwarf Tool");
                tm1 = true;
            }
        }
        else
        {
            tm1 = false;
            if (seenQuests.Contains("\n-Find a Dwarf Tool"))
            {
                seenQuests.Remove("\n-Find a Dwarf Tool");
            }
        }

        if (manager.townManTwoActive = true)
        {
            if (tm2 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Cliff Flower");
                tm2 = true;
            } 
        }
        else
        {
            tm2 = false;
            if (seenQuests.Contains("\n-Find Cliff Flower"))
            {
                seenQuests.Remove("\n-Find Cliff Flower");
            }
        }

        if (manager.crowKeyActive = true)
        {
            if (tc1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find a Nut for a Key");
                tc1 = true;
            }
        }
        else
        {
            tc1 = false;
            if (seenQuests.Contains("\n-Find a Nut for a Key"))
            {
                seenQuests.Remove("\n-Find a Nut for a Key");
            }
        }

        if (manager.crowOneActive = true)
        {
            if (fc1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get a lose Rock");
                fc1 = true;
            }
        }
        else
        {
            fc1 = false;
            if (seenQuests.Contains("\n-Get a lose Rock"))
            {
                seenQuests.Remove("\n-Get a lose Rock");
            }
        }

        if (manager.crowTwoActive = true)
        {
            if (fc2 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Find Red Gem");
                fc2 = true;
            }
        }
        else
        {
            fc2 = false;
            if (seenQuests.Contains("\n-Find Red Gem"))
            {
                seenQuests.Remove("\n-Find Red Gem");
            }
        }

        if (manager.crowThreeActive = true)
        {
            if (fc3 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Speak to Hecate");
                fc3 = true;
            }
        }
        else
        {
            fc3 = false;
            if (seenQuests.Contains("\n-Speak to Hecate"))
            {
                seenQuests.Remove("\n-Speak to Hecate");
            }
        }

        if (manager.crowFourActive = true)
        {
            if (fc4 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Have Familiar Spell");
                fc4 = true;
            }
        }
        else
        {
            fc4 = false;
            if (seenQuests.Contains("\n-Have Familiar Spell"))
            {
                seenQuests.Remove("\n-Have Familiar Spell");
            }
        }

        if (manager.hecateOneActive = true)
        {
            if (h1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Bug");
                h1 = true;
            }
        }
        else
        {
            h1 = false;
            if (seenQuests.Contains("\n-Get Bug"))
            {
                seenQuests.Remove("\n-Get Bug");
            }
        }

        if (manager.hecateTwoActive = true)
        {
            if (h2 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Cave Carrot");
                h2 = true;
            }
        }
        else
        {
            h2 = false;
            if (seenQuests.Contains("\n-Get Cave Carrot"))
            {
                seenQuests.Remove("\n-Get Cave Carrot");
            }
        }

        if (manager.hecateThreeActive = true)
        {
            if (h3 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Seed");
                h3 = true;
            }
        }
        else
        {
            h3 = false;
            if (seenQuests.Contains("\n-Get Seed"))
            {
                seenQuests.Remove("\n-Get Seed");
            }
        }

        if (manager.dwarfActive = true)
        {
            if (d1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get tiny, bright flower");
                d1 = true;
            }
        }
        else
        {
            d1 = false;
            if (seenQuests.Contains("\n-Get tiny, bright flower"))
            {
                seenQuests.Remove("\n-Get tiny, bright flower");
            }
        }

        if (manager.riverCrowOneActive = true)
        {
            if (rc1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get a Nut for a Scroll");
                rc1 = true;
            }
        }
        else
        {
            rc1 = false;
            if (seenQuests.Contains("\n-Get a Nut for a Scroll"))
            {
                seenQuests.Remove("\n-Get a Nut for a Scroll");
            }
        }

        if (manager.riverCrowTwoActive = true)
        {
            if (rc2 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Get Cave Flower");
                rc2 = true;
            }
        }
        else
        {
            rc2 = false;
            if (seenQuests.Contains("\n-Get Cave Flower"))
            {
                seenQuests.Remove("\n-Get Cave Flower");
            }
        }

        if (manager.riverGirlActive = true)
        {
            if (rg1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Golden Carp");
                rg1 = true;
            }
        }
        else
        {
            rg1 = false;
            if (seenQuests.Contains("\n-Catch a Golden Carp"))
            {
                seenQuests.Remove("\n-Catch a Golden Carp");
            }
        }

        if (manager.farmerOneActive = true)
        {
            if (f1 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Green Fish");
                f1 = true;
            }
        }
        else
        {
            f1 = false;
            if (seenQuests.Contains("\n-Catch a Green Fish"))
            {
                seenQuests.Remove("\n-Catch a Green Fish");
            }
        }

        if (manager.farmerTwoActive = true)
        {
            if (f2 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Blue Fish");
                f2 = true;
            }
        }
        else
        {
            f2 = false;
            if (seenQuests.Contains("\n-Catch a Blue Fish"))
            {
                seenQuests.Remove("\n-Catch a Blue Fish");
            }
        }

        if (manager.farmerThreeActive = true)
        {
            if (f3 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Purple Fish");
                f3 = true;
            }
        }
        else
        {
            f3 = false;
            if (seenQuests.Contains("\n-Catch a Purple Fish"))
            {
                seenQuests.Remove("\n-Catch a Purple Fish");
            }
        }

        if (manager.farmerFourActive = true)
        {
            if (f4 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Red Fish");
                f4 = true;
            }
        }
        else
        {
            f4 = false;
            if (seenQuests.Contains("\n-Catch a Red Fish"))
            {
                seenQuests.Remove("\n-Catch a Red Fish");
            }
        }

        if (manager.farmerFiveActive = true)
        {
            if (f5 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Orange Fish");
                f5 = true;
            }
        }
        else
        {
            f5 = false;
            if (seenQuests.Contains("\n-Catch a Orange Fish"))
            {
                seenQuests.Remove("\n-Catch a Orange Fish");
            }
        }

        if (manager.farmerSixActive = true)
        {
            if (f6 = true)
            {
                return;
            }
            else
            {
                seenQuests.Add("\n-Catch a Yellow Fish");
                f6 = true;
            }
        }
        else
        {
            f6 = false;
            if (seenQuests.Contains("\n-Catch a Yellow Fish"))
            {
                seenQuests.Remove("\n-Catch a Yellow Fish");
            }
        }

        questBox.text = "Quest List" + seenQuests;
    }
}
