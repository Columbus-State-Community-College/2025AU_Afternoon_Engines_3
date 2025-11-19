using UnityEngine;

public class SpellRockOutline : MonoBehaviour
{
    public float lifetime = 1.35f;
    void Awake()
    {Destroy(gameObject, lifetime);}
}