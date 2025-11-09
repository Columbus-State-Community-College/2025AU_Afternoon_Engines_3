using UnityEngine;
using TMPro;

public class repTracker : MonoBehaviour
{
    static public int reputation = 0;
    public TextMeshProUGUI winText;
    [HideInInspector] public static repTracker instance;

    void Start()
    {
        if (reputation <= -1)
        {
            reputation = 0;
        }
        winText.gameObject.SetActive(false);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void GetRep()
    {
        reputation += 1;
    }

    void Update()
    {
        if (reputation >= 10)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
