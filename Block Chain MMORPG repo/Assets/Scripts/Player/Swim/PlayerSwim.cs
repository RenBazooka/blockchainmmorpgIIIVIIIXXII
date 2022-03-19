using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwim : MonoBehaviour
{
    
    public bool isSwimming;

    private ThirdPersonController controller;
    private float controllerGravity;
    private float waterGravity;
    private float universalGravity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponentInParent<ThirdPersonController>();
        controllerGravity = controller.Gravity;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
         
       
        if(isSwimming == true)
        {
            controller.PlayerSwim();
        }

       if(isSwimming == false)
       {
            controller.EndSwim();
       }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            isSwimming = true;
            Debug.Log("inSide water");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            isSwimming = false;
            Debug.Log("outSide water");
        }

    }


    
    

    
}
