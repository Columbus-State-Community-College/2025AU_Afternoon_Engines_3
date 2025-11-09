using UnityEngine;
using System.Collections;
public class SpellSpeedEffect : MonoBehaviour
{
    [HideInInspector] public float ModifierValue = 1f;
    [HideInInspector] public float lifetime = 8f;
    [HideInInspector] public float speedModMulti = 1f;
    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
        PlayerController.instance.SpeedModifier(speedModMulti * (1f + (0.25f * ModifierValue)));
        PlayerController.instance.speedActive = true;
        StartCoroutine(RemoveSpeedEffectAfterDelay());
    }

    private IEnumerator RemoveSpeedEffectAfterDelay()
    {   
        yield return new WaitForSeconds((float)System.Math.Ceiling(lifetime * ModifierValue));
        PlayerController.instance.speedActive = false;
        Destroy(gameObject);
    }
}