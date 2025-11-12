using UnityEngine;
using TMPro;

public class isEmmaNear : MonoBehaviour
{
    bool emmaNear = false; // For it to know if Emma is close to an NPC.
    public TextMeshProUGUI approachedBox; // The UI box that let's the player know they can talk to an NPC
    public DialogueChat texty; // refers to the script with the dialogue changes
    string whichNPC; // Used later to get the tag from the NPC attached below.
    public GameObject thisNPC; // This is the NPC that the trigger is attached to.

    void Start()
    {
        emmaNear = false;
        approachedBox.gameObject.SetActive(false);
    }

    void OnTriggerEnter()
    {
        emmaNear = true;
        approachedBox.gameObject.SetActive(true);
    }

    void OnTriggerExit()
    {
        emmaNear = false;
        approachedBox.gameObject.SetActive(false);
        texty.NoMoreDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (emmaNear == true)
            {
                whichNPC = thisNPC.tag;
                texty.GetDialogue(whichNPC);
            }
        }
    }
}
