using UnityEngine;

public class ToggleMenuStatus : MonoBehaviour
{
    public GameObject Menu;
    public GameObject SpellMenu;
    public GameObject OptionsMenu;
    public GameObject DefaultMenu;
    private bool menuOpen;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpen)
                OpenMenu();
                //OpenMenu(currentMenuScreen);
            else
                CloseMenu();
                //CloseMenu(currentMenuScreen);
        }
    }
    public void OpenMenu()
    {
        Menu.SetActive(true);
        
    }
    public void CloseMenu()
    {
        Menu.SetActive(false);
    }    
}
