using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class PickupUnlock : MonoBehaviour
{
    [Header("Unlock Type")]
    [Tooltip("Name of the unlock variable in UnlockManager, e.g. 'fireSpellUnlocked' or 'parchment3x3'.")]
    public string unlockName;

    [Tooltip("If true, this pickup can only be collected once.")]
    public bool singleUse = true;

    [Tooltip("If true, this pickup destroys itself after unlocking.")]
    public bool destroyOnPickup = true;

    [Tooltip("Optional sound or VFX to play when picked up.")]
    // public AudioClip pickupSound;
    // private AudioSource audioSource;

    private bool collected = false;
    private UnlockManager unlockManager;

    private void Start()
    {
        // audioSource = GetComponent<AudioSource>();
        unlockManager = UnlockManager.instance;

        // If the unlock is already active, disable this pickup immediately
        if (IsAlreadyUnlocked())
        {
            gameObject.SetActive(false);
            return;
        }

        // Watch for scene loads in case this object is re-enabled/respawned
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Re-check on scene load (useful if this prefab is re-created)
        if (IsAlreadyUnlocked())
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
            TryUnlock();
    }

    private void TryUnlock()
    {
        if (UnlockManager.instance == null)
        {
            Debug.LogWarning("UnlockManager instance not found.");
            return;
        }

        var manager = UnlockManager.instance;
        FieldInfo field = typeof(UnlockManager).GetField(unlockName, BindingFlags.Public | BindingFlags.Instance);

        if (field == null)
        {
            Debug.LogWarning($"UnlockManager does not include '{unlockName}'.");
            return;
        }

        if (field.FieldType != typeof(bool))
        {
            Debug.LogWarning($"Unlock field '{unlockName}' is not a bool.");
            return;
        }

        // If already unlocked, nothing to do
        bool already = (bool)field.GetValue(manager);
        if (already)
        {
            collected = true;
            if (destroyOnPickup)
                Destroy(gameObject);
            else
                gameObject.SetActive(false);
            return;
        }

        // Set the unlock flag
        field.SetValue(manager, true);
        Debug.Log($"{unlockName} = true");

        collected = singleUse; // if singleUse is false, we still unlocked but don't mark collected to allow repeated picks (if desired)

        // Optional: play sound or VFX
        // if (pickupSound != null)
        // {
        //     if (audioSource == null)
        //         audioSource = gameObject.AddComponent<AudioSource>();
        //     audioSource.PlayOneShot(pickupSound);
        // }

        // Remove or hide the pickup
        if (destroyOnPickup)
            Destroy(gameObject);
        else
            gameObject.SetActive(false);
    }

    private bool IsAlreadyUnlocked()
    {
        if (UnlockManager.instance == null) return false;

        FieldInfo field = typeof(UnlockManager).GetField(unlockName, BindingFlags.Public | BindingFlags.Instance);
        if (field == null)
        {
            Debug.LogWarning($"Unlock field '{unlockName}' not found in UnlockManager.");
            return false;
        }

        if (field.FieldType != typeof(bool))
        {
            Debug.LogWarning($"Unlock field '{unlockName}' is not a bool.");
            return false;
        }

        return (bool)field.GetValue(UnlockManager.instance);
    }
}