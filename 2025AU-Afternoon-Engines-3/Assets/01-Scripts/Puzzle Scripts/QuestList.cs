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
    }
}
