using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager instance;
    public bool gameMenuOpen, dialogueActive;
    public string targetAreaTransition;
    private bool dataLoadedFromFile = false, canSave = false;
    public bool debugEnabled = true, checkPlayerMovement = false;
    void Start()
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
    }
    void Update()
    {
        if((gameMenuOpen || dialogueActive) && checkPlayerMovement)
        {

            PlayerController.instance.ToggleMovementStatus(false);
            checkPlayerMovement = false;
        }
        else
        {
            PlayerController.instance.ToggleMovementStatus(true);
            checkPlayerMovement = false;
        }
        // if((!dataLoadedFromFile && !debugEnabled) || Input.GetKeyDown(KeyCode.Q))
        // {
        //     Debug.Log("Data Loaded");
        //     LoadData();
        //     dataLoadedFromFile = true;
        //     canSave = true;
        // }
        // if(Input.GetKeyDown(KeyCode.E) && canSave)
        // {
        //     Debug.Log("Data Saved");
        //     SaveData();
        // }
    }

    public void SaveData()
    {
        //Below is the preset load condtion, add String or Int to set variables desired. 
        //PlayerPrefs.Set
        // PlayerPrefs.SetString("Active_Scene_Location", SceneManager.GetActiveScene().name);
        // PlayerPrefs.SetFloat("Player_Position_X", PlayerController.instance.transform.position.x);
        // PlayerPrefs.SetFloat("Player_Position_Y", PlayerController.instance.transform.position.y);
        // PlayerPrefs.SetFloat("Player_Position_Z", PlayerController.instance.transform.position.z);
    }
    public void LoadData()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Active_Scene_Location", SceneManager.GetActiveScene().name));
        PlayerController.instance.transform.position = new Vector3(PlayerPrefs.GetFloat("Player_Position_X"), PlayerPrefs.GetFloat("Player_Position_Y"), PlayerPrefs.GetFloat("Player_Position_Z"));
    }
}
 