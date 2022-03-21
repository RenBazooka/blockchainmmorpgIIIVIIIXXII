using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    [SerializeField] private GameObject[] characterList;
    private int Index;

    //private charac

    // Start is called before the first frame update
    void Start()
    {
        Index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];
        //fill the array with characters
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }


        foreach(GameObject go in characterList)
        {
            go.SetActive(false);
        }

        if (characterList[Index])
        {
            characterList[Index].SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", Index);
        SceneManager.LoadScene(3);

    }

    public void SelectPrevious()
    {
        characterList[Index].SetActive(false);


        Index--;
        if(Index < 0)
        {
            Index = characterList.Length - 1;
        }

        characterList[Index].SetActive(true);
    }

    public void SelectNext()
    {
        characterList[Index].SetActive(false);


        Index++;
        if (Index == characterList.Length)
        {
            Index = 0;
        }

        characterList[Index].SetActive(true);
    }
}
