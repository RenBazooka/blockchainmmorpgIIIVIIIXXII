using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public enum CharacterStates { Standing, Crouching, Proning }

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class ThirdPersonController : MonoBehaviour
{
	[Header("Player")]
	[Tooltip("Move speed of the character in m/s")]
	public float MoveSpeed = 2.0f;
	[Tooltip("Sprint speed of the character in m/s")]
	public float SprintSpeed = 5.335f;
	[Tooltip("How fast the character turns to face movement direction")]
	[Range(0.0f, 0.3f)]
	public float RotationSmoothTime = 0.12f;
	[Tooltip("Acceleration and deceleration")]
	public float SpeedChangeRate = 10.0f;

	[Space(10)]
	public bool canJump = true;
	[Tooltip("The height the player can jump")]
	public float JumpHeight = 1.2f;
	[Tooltip("The character uses its own gravity value. The engine default is -9.81f")]
	public float Gravity = -15.0f;

	[Space(10)]
	[Tooltip("Time required to pass before being able to jump again. Set to 0f to instantly jump again")]
	public float JumpTimeout = 0.50f;
	[Tooltip("Time required to pass before entering the fall state. Useful for walking down stairs")]
	public float FallTimeout = 0.15f;


	/*Prev Crouch Vars

	[Space(10)]
	public float crouchHeight = 0.5f;
	public float standingheight = 2f;
	public float timeToCrouch = 0.25f;
	public Vector3 crouchingCenter = new Vector3(0, 0.5f, 0);
	public Vector3 standingCenter = new Vector3(0, 0, 0);
	private bool isCrouching;
	private bool duringCrouchAnimation;
	//[SerializeField]private bool canCrouch = true;
	//private bool ShouldCrouch => _input.crouch && !duringCrouchAnimation && Grounded;
	*/
	[Space]
	[Header("Player Crouch")]
	public float crouchWalk;
	public float crouchSprint;
	private float originalHeight;
	public float crouchedHeight;
	private Vector3 originalCenter;
	public Vector3 crouchedCenter;
	private float originalRadius;
	public float crouchedRadius;
	public Transform cellingChecker;
	public bool isCrouched = false;
	public float standDistance;
	public bool cellingCheck;
	[Header("Player Grounded")]
	[Tooltip("GameObject That detects Ground,Place It under player")]
	public Transform GroundChecker;
	[Tooltip("If the character is grounded or not. Not part of the CharacterController built in grounded check")]
	public bool Grounded = true;
	[Tooltip("Useful for rough ground")]
	public float GroundedOffset = -0.14f;
	[Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
	public float GroundedRadius = 0.28f;
	[Tooltip("What layers the character uses as ground")]
	public LayerMask GroundLayers;

	[Header("Cinemachine")]
	[Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
	public GameObject CinemachineCameraTarget;
	[Tooltip("How far in degrees can you move the camera up")]
	public float TopClamp = 70.0f;
	[Tooltip("How far in degrees can you move the camera down")]
	public float BottomClamp = -30.0f;
	[Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked")]
	public float CameraAngleOverride = 0.0f;
	[Tooltip("For locking the camera position on all axis")]
	public bool LockCameraPosition = false;

	[Header("Slope Detection")]
	[SerializeField]private float _groundRayDistance = 1;
	private RaycastHit _slopeHit;
	[SerializeField]private bool willSlideOnSlopes = true;
	[SerializeField]private float slopeSlideSpeed = 8;


	private Vector3 targetDirection;


	// cinemachine
	private float _cinemachineTargetYaw;
	private float _cinemachineTargetPitch;

	// player
	private float _speed;
	private float _animationBlend;
	private float _targetRotation = 0.0f;
	private float _rotationVelocity;
	private float _verticalVelocity;
	private float _terminalVelocity = 53.0f;
	private float targetSpeed;
	// timeout deltatime
	private float _jumpTimeoutDelta;
	private float _fallTimeoutDelta;


	//Combat
	public bool canRotate;
	public bool independentRotation;
	public bool cameraRotation;
	public float lookSpeed = 2.0f;
	public float lookXLimit = 45.0f;
	float rotationX;
	// animation IDs
	private int _animIDSpeed;
	private int _animIDGrounded;
	private int _animIDJump;
	private int _animIDFreeFall;
	private int _animIDMotionSpeed;
	private int _animIDCrouch;
	private int _animIDSwim;

	private Animator _animator;
	private CharacterController _controller;
	private StarterAssetsInputs _input;
	private GameObject _mainCamera;
	private CharacterStates _stance;

	private const float _threshold = 0.01f;

	private bool _hasAnimator;

	[HideInInspector] public Vector2 isMoving;

	private void Awake()
	{
		// get a reference to our main camera
		if (_mainCamera == null)
		{
			_mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
		}
	}

	private void Start()
	{
		_hasAnimator = TryGetComponent(out _animator);
		_controller = GetComponent<CharacterController>();
		_input = GetComponent<StarterAssetsInputs>();

		AssignAnimationIDs();

		// reset our timeouts on start
		_jumpTimeoutDelta = JumpTimeout;
		_fallTimeoutDelta = FallTimeout;

		//Crouch
		originalHeight = _controller.height;
		originalCenter = _controller.center;
		originalRadius = _controller.radius;
	}

	private void Update()
	{
		_hasAnimator = TryGetComponent(out _animator);


		Move();
		GroundedCheck();
		JumpAndGravity();
		Crouch();

        


		//Debug.Log(_controller.velocity.magnitude);
	}



	private void LateUpdate()
	{
		CameraRotation();
	}

	private void AssignAnimationIDs()
	{
		_animIDSpeed = Animator.StringToHash("Speed");
		_animIDGrounded = Animator.StringToHash("Grounded");
		_animIDJump = Animator.StringToHash("Jump");
		_animIDFreeFall = Animator.StringToHash("FreeFall");
		_animIDMotionSpeed = Animator.StringToHash("MotionSpeed");
		_animIDCrouch = Animator.StringToHash("Crouch");
		_animIDSwim = Animator.StringToHash("Swim");
	}

	private void GroundedCheck()
	{
		// set sphere position, with offset
		//Vector3 spherePosition = new Vector3(transform.position.x, transform.position.y - GroundedOffset, transform.position.z);
		//Grounded = Physics.CheckSphere(GroundChecker.position, GroundedRadius, GroundLayers, QueryTriggerInteraction.Ignore);
		Grounded = _controller.isGrounded;
		cellingCheck = Physics.CheckSphere(cellingChecker.position, standDistance, GroundLayers);
		// update animator if using character
		if (_hasAnimator)
		{
			_animator.SetBool(_animIDGrounded, Grounded);
		}
	}

	private void CameraRotation()
	{
		// if there is an input and camera position is not fixed
		if (_input.look.sqrMagnitude >= _threshold && !LockCameraPosition)
		{
			_cinemachineTargetYaw += _input.look.x * Time.deltaTime;
			_cinemachineTargetPitch += _input.look.y * Time.deltaTime;
		}

		// clamp our rotations so our values are limited 360 degrees
		_cinemachineTargetYaw = ClampAngle(_cinemachineTargetYaw, float.MinValue, float.MaxValue);
		_cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, BottomClamp, TopClamp);

		// Cinemachine will follow this target
		CinemachineCameraTarget.transform.rotation = Quaternion.Euler(_cinemachineTargetPitch + CameraAngleOverride, _cinemachineTargetYaw, 0.0f);
	}

	private void Move()
	{
		// set target speed based on move speed, sprint speed and if sprint is pressed
		targetSpeed = _input.sprint ? SprintSpeed : MoveSpeed;

		isMoving = _input.move;
		// a simplistic acceleration and deceleration designed to be easy to remove, replace, or iterate upon

		// note: Vector2's == operator uses approximation so is not floating point error prone, and is cheaper than magnitude
		// if there is no input, set the target speed to 0
		if (_input.move == Vector2.zero) targetSpeed = 0.0f;

		// a reference to the players current horizontal velocity
		float currentHorizontalSpeed = new Vector3(_controller.velocity.x, 0.0f, _controller.velocity.z).magnitude;

		float speedOffset = 0.1f;
		float inputMagnitude = _input.analogMovement ? _input.move.magnitude : 1f;

		// accelerate or decelerate to target speed
		if (currentHorizontalSpeed < targetSpeed - speedOffset || currentHorizontalSpeed > targetSpeed + speedOffset)
		{
			// creates curved result rather than a linear one giving a more organic speed change
			// note T in Lerp is clamped, so we don't need to clamp our speed
			_speed = Mathf.Lerp(currentHorizontalSpeed, targetSpeed * inputMagnitude, Time.deltaTime * SpeedChangeRate);

			// round speed to 3 decimal places
			_speed = Mathf.Round(_speed * 1000f) / 1000f;
		}
		else
		{
			_speed = targetSpeed;
		}
		_animationBlend = Mathf.Lerp(_animationBlend, targetSpeed, Time.deltaTime * SpeedChangeRate);

		// normalise input direction
		Vector3 inputDirection = new Vector3(_input.move.x, 0.0f, _input.move.y).normalized;

        // note: Vector2's != operator uses approximation so is not floating point error prone, and is cheaper than magnitude
        // if there is a move input rotate player when the player is moving

        if (canRotate == true)
        {
			if(independentRotation == true)
            {
				if (_input.move != Vector2.zero)
				{
					_targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + _mainCamera.transform.eulerAngles.y;
					float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetRotation, ref _rotationVelocity, RotationSmoothTime);

					// rotate to face input direction relative to camera position
					transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
				}
			}
			/*
			if(cameraRotation == true)
            {
				if (_input.move != Vector2.zero)
				{	
					_targetRotation = Quaternion.LookRotation(_mainCamera.);
				}



			}
			*/


        }
        

		


		
		targetDirection = Quaternion.Euler(0.0f, _targetRotation, 0.0f) * Vector3.forward;

		/*
		if(willSlideOnSlopes && isSliding)
        {
			_controller.Move ( new Vector3(hitPointNormal.x, -hitPointNormal.y, hitPointNormal.z) * slopeSlideSpeed);
        }
		*/
		/*
		if (CheckMoveableTerrain(transform.position, new Vector3(targetDirection.x, 0, targetDirection.z), 10f)) ;
        {
			_controller.Move(targetDirection.normalized);
        }
		*/
		//crouchSpeed Settings
		float _stateSpeed;
		//crouch
		_stateSpeed = isCrouched ? (_input.sprint ? _speed * crouchSprint : _speed * crouchWalk) : _speed;

		//Debug.Log(_stateSpeed);

		// move the player
		_controller.Move(targetDirection.normalized * (_stateSpeed * Time.deltaTime) + new Vector3(0.0f, _verticalVelocity, 0.0f) * Time.deltaTime);



		// update animator if using character
		if (_hasAnimator)
		{
			_animator.SetFloat(_animIDSpeed, _animationBlend);
			_animator.SetFloat(_animIDMotionSpeed, inputMagnitude);
		}
	}
	
	
		
	

	private void JumpAndGravity()
	{
		if (_controller.isGrounded)
		{
			// reset the fall timeout timer
			_fallTimeoutDelta = FallTimeout;

			// update animator if using character
			if (_hasAnimator)
			{
				_animator.SetBool(_animIDJump, false);
				_animator.SetBool(_animIDFreeFall, false);
			}

			// stop our velocity dropping infinitely when grounded
			if (_verticalVelocity < 0.0f)
			{
				_verticalVelocity = -4.5f;
			}

			if (canJump)
			{
				// Jump
				if (_input.jump && _jumpTimeoutDelta <= 0.0f)
				{

					// the square root of H * -2 * G = how much velocity needed to reach desired height
					_verticalVelocity = Mathf.Sqrt(JumpHeight * -2f * Gravity);

					// update animator if using character
					if (_hasAnimator)
					{
						_animator.SetBool(_animIDJump, true);
					}
				}

				// jump timeout
				if (_jumpTimeoutDelta >= 0.0f)
				{
					_jumpTimeoutDelta -= Time.deltaTime;
				}
			}


		}
		else
		{
			// reset the jump timeout timer
			_jumpTimeoutDelta = JumpTimeout;

			// fall timeout
			if (_fallTimeoutDelta >= 0.0f)
			{
				_fallTimeoutDelta -= Time.deltaTime;
			}
			else
			{
				// update animator if using character
				if (_hasAnimator)
				{
					_animator.SetBool(_animIDFreeFall, true);
				}
			}

			// if we are not grounded, do not jump
			_input.jump = false;
		}


		// apply gravity over time if under terminal (multiply by delta time twice to linearly speed up over time)
		if (_verticalVelocity < _terminalVelocity)
		{
			_verticalVelocity += Gravity * Time.deltaTime;
		}
	}



	private void Crouch()
	{


		if (Input.GetKeyDown(KeyCode.C) && isCrouched == false)
		{
			canJump = false;
			StandToCrouch();
			isCrouched = true;


		}
		else if (Input.GetKeyUp(KeyCode.C))
		{

			if (cellingCheck == false)
			{
				CrouchToStand();
				isCrouched = false;
				canJump = true;
			}

		}



	}


	#region CrouchFunctions
	private void CrouchToStand()
	{

		_controller.height = originalHeight;
		_controller.center = originalCenter;
		_controller.radius = originalRadius;
		_animator.SetBool(_animIDCrouch, false);

	}
	private void StandToCrouch()
	{

		_controller.height = crouchedHeight;
		_controller.center = crouchedCenter;
		_controller.radius = crouchedRadius;
		_animator.SetBool(_animIDCrouch, true);


	}
	#endregion

	private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
	{
		if (lfAngle < -360f) lfAngle += 360f;
		if (lfAngle > 360f) lfAngle -= 360f;
		return Mathf.Clamp(lfAngle, lfMin, lfMax);
	}

	

	


	public void PlayerSwim()
    {
		_verticalVelocity = 0;
		_animator.SetBool(_animIDSwim, true);

		
    }
	public void EndSwim()
    {
		_animator.SetBool(_animIDSwim, false);
	}

	private void OnDrawGizmosSelected()
	{
		Color transparentGreen = new Color(0.0f, 1.0f, 0.0f, 0.35f);
		Color transparentRed = new Color(1.0f, 0.0f, 0.0f, 0.35f);

		if (Grounded || cellingCheck) Gizmos.color = transparentGreen;
		else Gizmos.color = transparentRed;

		// when selected, draw a gizmo in the position of, and matching radius of, the grounded collider
		Gizmos.DrawSphere(cellingChecker.position, standDistance);
		//Gizmos.DrawLine(transform.position, transform.position + Vector3.up);

		Gizmos.color = Color.cyan;
		Gizmos.DrawLine(transform.position,Vector3.down*_groundRayDistance );
	}

}