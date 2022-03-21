using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuExit : MonoBehaviour
{

    bool isMenuPaused = false;
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isMenuPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }




    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isMenuPaused = false;
    }

    void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isMenuPaused = true;
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
    
