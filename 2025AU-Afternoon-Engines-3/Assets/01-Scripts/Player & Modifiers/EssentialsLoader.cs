using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public static EssentialsLoader instance;

    [Header("Essential Prefabs")]
    public GameObject Player;
    public GameObject GameManagerPrefab;
    public GameObject UnlockManagerPrefab;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        { if(instance != this)
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        LoadEssentials();
    }

    private void LoadEssentials()
    {
        if (PlayerController.instance == null)
        {
            PlayerController clone = Instantiate(Player, transform.position, transform.rotation).GetComponent<PlayerController>();
            PlayerController.instance = clone;
        }
        if (GameManager.instance == null)
        {
            GameManager clone = Instantiate(GameManagerPrefab).GetComponent<GameManager>();
            GameManager.instance = clone;
        }
        if (UnlockManager.instance == null)
        {
            UnlockManager clone = Instantiate(UnlockManagerPrefab).GetComponent<UnlockManager>();
            UnlockManager.instance = clone;
        }
    }
}