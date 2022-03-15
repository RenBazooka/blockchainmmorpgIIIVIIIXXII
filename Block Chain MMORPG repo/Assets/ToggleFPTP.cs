using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFPTP : MonoBehaviour
{
    public KeyCode SwitchPlayModeTP;
    public KeyCode SwitchPlayModeFP;
    public GameObject tp_Player;
    public GameObject fp_Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(SwitchPlayModeFP))
        {
            tp_Player.gameObject.SetActive(false);
            fp_Player.gameObject.SetActive(true);


        }
        if (Input.GetKeyDown(SwitchPlayModeTP))
        {
            tp_Player.gameObject.SetActive(true);
            fp_Player.gameObject.SetActive(false);


        }
    }
}
