using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
	[SerializeField] InputAction thrust;
	[SerializeField] InputAction rotation;
	[SerializeField] float thrustStrength = 10f;
	[SerializeField] float rotationStrength = 100f;
	Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();

	}

	private void OnEnable()
	{
		thrust.Enable();
		rotation.Enable();
	}

	private void FixedUpdate()
	{
		IgniteEngine();
		ActivateRotation();
	}

	private void IgniteEngine()
	{
		if (thrust.IsPressed())
		{
			rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
		}
	}

	private void ActivateRotation()
	{
		float rotationInput = rotation.ReadValue<float>();

		if (rotationInput < 0)
		{
			ApplyRotation(rotationStrength);
			Debug.Log("Rotation Left");
		}

		else if (rotationInput > 0)
		{
			ApplyRotation(-rotationStrength);
			Debug.Log("Rotation Right");

		}

	}

	private void ApplyRotation(float rotationThisFrame)
	{
		transform.Rotate(Vector3.forward * rotationThisFrame * Time.fixedDeltaTime);
	}
}
