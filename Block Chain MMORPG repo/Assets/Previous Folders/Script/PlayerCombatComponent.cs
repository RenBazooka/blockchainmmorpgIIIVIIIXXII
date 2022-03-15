using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace StarterAssets
{
    public class PlayerCombatComponent : MonoBehaviour
    {

        private Animator _anim;
        private ThirdPersonController _controller;
        private float smoothCombatLayerIndex;

        [SerializeField] private bool activateCombat = false;
        [SerializeField] private bool stopCombat = false;
        [SerializeField] private float weaponDrawTimer = 10f;
        [SerializeField] private float weaponHolsterTimer = 10f;

        public GameObject weaponRestPos;
        public GameObject weaponDrawPos;

        //Attack variables
        [Space]
        public float coolDowntime = 2f;
        //private float nextFireTime = 0f;
        public static int noOfClicks = 0;
        //private float lastClickedTime = 0f;
        //private float maxComboDelay = 1f;

        // Start is called before the first frame update
        void Start()
        {
            _anim = GetComponent<Animator>();
            _controller = GetComponent<ThirdPersonController>();
        }

        // Update is called once per frame
        void Update()
        {

            //smoothCombatLayerIndex = Mathf.Lerp(_anim.GetLayerWeight(1), 1f, Time.deltaTime * 10f);

            if (Input.GetMouseButtonDown(2))
            {
                activateCombat = true;

            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                activateCombat = false;

            }


            if (activateCombat == true)
            {
                StartCombatLayer();
                _anim.SetBool("activateCombat", true);
                stopCombat = false;
            }

            if (activateCombat == false)
            {

                _anim.SetBool("activateCombat", false);
            }

            if (stopCombat == true)
            {
                _anim.SetLayerWeight(1, Mathf.Lerp(_anim.GetLayerWeight(1), 0f, Time.deltaTime * weaponHolsterTimer));
            }

            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }


            

            if (_controller.isMoving != Vector2.zero)
            {
                _anim.SetLayerWeight(2, 0);
            }

        }


        private void StartCombatLayer()
        {
            _anim.SetLayerWeight(1, Mathf.Lerp(_anim.GetLayerWeight(1), 1f, Time.deltaTime * weaponDrawTimer));
        }


        public void StopCombatLayer()
        {
            stopCombat = true;

        }

        private void ShowWeapon()
        {

        }

        private void HideWeapon()
        {

        }



        //ATTACK FUNCTION AND SETTINGS
        private void OnClick()
        {

            noOfClicks++;
            if (noOfClicks == 1)
            {
                _anim.SetBool("hit 1", true);
                _anim.SetLayerWeight(2, 1);

            }
            noOfClicks = Mathf.Clamp(noOfClicks, 0, 4);
            if (noOfClicks >= 2)
            {
                _anim.SetBool("hit 2", true);
                _anim.SetBool("hit 1", false);
                _anim.SetLayerWeight(2, 1);

            }
            if (noOfClicks >= 3)
            {
                _anim.SetBool("hit 2", false);
                _anim.SetBool("hit 3", true);
                _anim.SetLayerWeight(2, 1);

            }
            if (noOfClicks >= 4)
            {
                _anim.SetBool("hit 3", false);
                noOfClicks = 0;
                _anim.SetLayerWeight(2, 1);

            }

        }




        public void ActivateWeaponDrawPos()
        {
            weaponDrawPos.SetActive(true);
        }
        public void DeActivateWeaponDrawPos()
        {
            weaponDrawPos.SetActive(false);
        }
        public void ActivateWeaponRestPos()
        {
            weaponRestPos.SetActive(true);
        }
        public void DeActivateWeaponRestPos()
        {
            weaponRestPos.SetActive(false);

        }
    }
}
