using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerCombatComponent : MonoBehaviour
{
    public GameObject mainMeapon;
    public GameObject holsterdWeapon;

    private bool Attacked;

    private Animator _ANIM;

    bool isAttacking;

    public bool WeaponDraw = false;
    float countdowntime;

    //_anim.SetLayerWeight(2, 0);

    private void Start()
    {
        _ANIM = GetComponent<Animator>();
    }
    private void Update()
    {
        Attacked = Input.GetMouseButtonDown(0);

        
        if (Attacked)
        {

            

            

            _ANIM.SetBool("hit 1", true);


          
        }
        else
        {
            _ANIM.SetBool("hit 1", false);
        }

        if (Attacked)
        {
            countdowntime = 0;
            countdowntime = Time.time;
        }

        if (WeaponDraw == false && Input.GetMouseButtonDown(1))
        {
            _ANIM.SetLayerWeight(1, 1);

            _ANIM.SetBool("Draw", true);

            WeaponDraw = true;
        }
        else
        {
            _ANIM.SetBool("Draw", false);
        }

        if (Input.GetMouseButtonDown(2))
        {
            _ANIM.SetBool("Hide", true);
            WeaponDraw = false;
        }
        else
        {
            _ANIM.SetBool("Hide", false);
        }
    }


    public void DrawWeapon()
    {

        mainMeapon.transform.gameObject.SetActive(true);
        holsterdWeapon.transform.gameObject.SetActive(false);
        

    }

    public void HideWeapon()
    {

        mainMeapon.transform.gameObject.SetActive(false);
        holsterdWeapon.transform.gameObject.SetActive(true);
       

        
    }

    public void ResetPos()
    {

        _ANIM.SetLayerWeight(1, 0);
    }

}
