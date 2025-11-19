using UnityEngine;

public class SpellThunderEffect : MonoBehaviour
{
    [HideInInspector] public float ModifierValue = 1f;
    public float lifetime = 1.5f;
    public float expansionSpeed = 15f;
    public float maxScale = 7f;
    private float currentScale = 0.2f;

    void Awake()
    {
        ModifierValue *= PlayerController.instance.spellPowerMod;
        Destroy(gameObject, lifetime * ModifierValue);

        transform.localScale = Vector3.one * currentScale;
    }

    void Update()
    {
        currentScale += expansionSpeed * Time.deltaTime * ModifierValue;
        currentScale = Mathf.Min(currentScale, maxScale * ModifierValue);

        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {return;}

        Powerable powerable = other.GetComponent<Powerable>();
        if (powerable != null)
        {powerable.TogglePower();}
    }
}