using UnityEngine;
using TMPro;

public class isEmmaNear : MonoBehaviour
{
    bool emmaNear = false; // For it to know if Emma is close to an NPC.
    public GameObject approachedBox; // The UI box that let's the player know they can talk to an NPC
    public DialogueChat dialogueChatScript; // refers to the script with the dialogue changes
    string whichNPC; // Used later to get the tag from the NPC attached below.
    public string thisNPC; // This is the NPC that the trigger is attached to.
    private bool foundPlayer;
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (thisNPC == null)
        {thisNPC = "nullPlaceholder";}

        emmaNear = false;
        approachedBox.SetActive(false);
    }

    void OnTriggerEnter()
    {
        emmaNear = true;
        approachedBox.SetActive(true);
    }

    void FixedUpdate()
    {
        if (!foundPlayer)
        { FindPlayer(); }
    }
    void FindPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        dialogueChatScript = player.GetComponent<DialogueChat>();
        foundPlayer = true;
    }
    void OnTriggerExit()
    {
        emmaNear = false;
        approachedBox.gameObject.SetActive(false);
        dialogueChatScript.NoMoreDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (emmaNear == true)
            {
                whichNPC = thisNPC;
                dialogueChatScript.GetDialogue(whichNPC);
            }
        }
    }
}
