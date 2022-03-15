using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void OnClick_start()
    {
        SceneManager.LoadScene(1);

    }

    public void OnClick_Settings()
    {
        MenuManager.OpenMenu(Menu.SETTINGS, gameObject);


    }

    public void OnClick_Shop()
    {
        MenuManager.OpenMenu(Menu.SHOP, gameObject);


    }

    public void OnClick_Exit()
    {
        //Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Game Is Exiting");

    }

}
