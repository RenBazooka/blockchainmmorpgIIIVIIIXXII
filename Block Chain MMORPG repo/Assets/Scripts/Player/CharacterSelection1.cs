using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection1 : MonoBehaviour
{

    [SerializeField] private GameObject[] characters;
    public int selectedCharacter = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);

    }

    public void SelectPrevious()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;

        if(selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);

       
    }

    public void SelectNext()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }
}
