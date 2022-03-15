using UnityEngine;

public static class MenuManager
{

    public static bool IsInitialised { get; private set; }

    public static GameObject mainMenu, settingsMenu, shopMenu;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Menu Holder (MAIN)");
        mainMenu = canvas.transform.Find("Main Menu ").gameObject;
        settingsMenu = canvas.transform.Find("Settings Menu").gameObject;
        shopMenu = canvas.transform.Find("Shop Menu").gameObject;

        IsInitialised = true;

    }

    public static void OpenMenu(Menu menu,GameObject callingMenu)
    {
        if (!IsInitialised)
        {
            Init();
        }
        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
            case Menu.SETTINGS:
                settingsMenu.SetActive(true);
                break;
            case Menu.SHOP:
                shopMenu.SetActive(true);
                break;

        }

        callingMenu.SetActive(false);

    }

}
