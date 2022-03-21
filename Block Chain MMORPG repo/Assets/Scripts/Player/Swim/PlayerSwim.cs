using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwim : MonoBehaviour
{
    
    public bool isSwimming;

    public Animator _animator;
    private ThirdPersonController _controller;
    private float controllerGravity;
    private float waterGravity;
    private float universalGravity;

    // Start is called before the first frame update
    void Start()
    {

        _controller = GetComponentInParent<ThirdPersonController>();
        _animator = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (isSwimming)
        {
            playerSwim();
        }

        if (!isSwimming)
        {
            EndSwim();
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


    public void playerSwim()
    {
        _controller._verticalVelocity = 0;
        _animator.SetBool("Swim", true);


    }
    public void EndSwim()
    {
        _animator.SetBool("Swim", false);
    }



}
