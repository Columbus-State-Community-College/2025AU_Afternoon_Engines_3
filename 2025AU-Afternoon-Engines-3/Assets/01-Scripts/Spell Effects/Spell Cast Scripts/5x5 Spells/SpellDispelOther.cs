using UnityEngine;

public class SpellDispelOther : SpellBase
{
    public override void ActivateSpell()
    {
        // Destroy all summoned objects
        GameObject[] summonedObjects = GameObject.FindGameObjectsWithTag("Summoned");

        foreach (GameObject obj in summonedObjects)
        {
            Destroy(obj);
        }

        // Reset player's hand pose
        if (SpellSelector.instance != null)
            SpellSelector.instance.ResetHand();

        // Destroy the held spell object
        Destroy(gameObject);
    }
}