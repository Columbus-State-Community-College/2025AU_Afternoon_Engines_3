using UnityEngine;

public class SpellGravity : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;

    [Tooltip("Optional visual effect to attach to the player when casting.")]
    public GameObject gravityEffectPrefab;

    void Awake()
    {ModifierValue *= PlayerController.instance.spellPowerMod;}

    public override void ActivateSpell()
    {
        if (PlayerController.instance == null)
            {return;}
        Transform playerTransform = PlayerController.instance.transform;

        if (gravityEffectPrefab != null)
        {
            GameObject effect = Instantiate(gravityEffectPrefab, playerTransform);
            effect.transform.localPosition = Vector3.zero;
            effect.transform.localRotation = Quaternion.identity;

            var gravityEffect = effect.GetComponent<SpellGravityEffect>();
            if (gravityEffect != null)
                {gravityEffect.ModifierValue = ModifierValue;}
        }

        SpellSelector.instance.ResetHand();
        Destroy(gameObject);
    }
}