using UnityEngine;

public class SpellSpeed : SpellBase
{
    [HideInInspector] public float ModifierValue = 1f;

    [Tooltip("Optional visual effect to attach to the player when casting.")]
    public GameObject speedEffectPrefab;

    private GameObject attachedEffect;

    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
    }

    public override void ActivateSpell()
    {
        if (PlayerController.instance == null)
        {
            return;
        }

        Transform playerTransform = PlayerController.instance.transform;

        if (speedEffectPrefab != null)
        {
            attachedEffect = Instantiate(speedEffectPrefab, playerTransform);
            attachedEffect.transform.localPosition = Vector3.zero;
            attachedEffect.transform.localRotation = Quaternion.identity;

        }


        Destroy(gameObject);
    }
}