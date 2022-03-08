using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseController : MonoBehaviour
{
    private Rigidbody horseRB;

	private Transform _mainCam;
    public float _speed;
    float _rotationVelocity;
    float RotationSmoothTime;

    // Start is called before the first frame update
    void Start()
    {
        horseRB = GetComponent<Rigidbody>();

		_mainCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	float sprintspeed;
	float walkspeed;
	float targetSpeed;
	Vector2 isMoving;
	float SpeedChangeRate;


	float targetRotation;
	
	private void Move()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector2 inputVector = new Vector3(horizontal, vertical).normalized;



        if (inputVector.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(inputVector.x, inputVector.y) * Mathf.Rad2Deg + _mainCam.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _rotationVelocity, RotationSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            horseRB.velocity = moveDir.normalized * _speed;
        }

       
    }

}

