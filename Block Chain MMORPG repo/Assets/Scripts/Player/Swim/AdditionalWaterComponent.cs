using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalWaterComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player") && other.GetComponent<ThirdPersonController>() != null)
        {
            ThirdPersonController controller = other.GetComponent<ThirdPersonController>();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
    }



}
