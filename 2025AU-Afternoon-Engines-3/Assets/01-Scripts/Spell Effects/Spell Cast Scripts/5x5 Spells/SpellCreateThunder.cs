using UnityEngine;

public class SpellCreateThunder : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;
    public float maxDistance = 40f;
    public LayerMask hitMask;
    public GameObject thunderEffect;
    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
        maxDistance *= ModifierValue;
    }
    public override void ActivateSpell()
    {
        if (thunderEffect == null)
        {return;}
        Vector3 origin = PlayerController.instance.transform.position;
        Vector3 direction = PlayerController.instance.transform.forward;
        RaycastHit hit;

        Vector3 spawnPos;

        if (Physics.Raycast(origin, direction, out hit, maxDistance, hitMask))
        {
            spawnPos = hit.point;
        }
        else
        {
            spawnPos = origin + direction * maxDistance;
        }
        GameObject fx = Instantiate(thunderEffect, spawnPos, Quaternion.identity);
        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}
