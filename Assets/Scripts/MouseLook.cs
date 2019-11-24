using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public float MouseSensitivity;
	public Transform PlayerTransform;
	
	private float XRotation;
    private float MouseX;
	private float MouseY;
	private Rigidbody body;

	void Start()
	{
		Cursor.lockState = CursorLockMode.None;
		body = gameObject.GetComponent<Rigidbody>();
	}

    void Update()
    {
		if (Input.GetKey(KeyCode.Escape)) {
			if (Cursor.lockState == CursorLockMode.Locked) {
				Cursor.lockState = CursorLockMode.None;
			}
		}
		if (Input.GetMouseButtonDown(0)) {
			if (Cursor.lockState == CursorLockMode.None) {
				Cursor.lockState = CursorLockMode.Locked;
			}
		}

		if (Cursor.lockState == CursorLockMode.Locked) {
			MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
			MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
			/*
			XRotation = PlayerTransform.localRotation.x;
			XRotation -= MouseY;
			XRotation = Mathf.Clamp(XRotation, -90F, 90F);
			transform.localRotation = Quaternion.Euler(XRotation, 0F, 0F);
			PlayerTransform.Rotate(Vector3.up * MouseX);
			*/
			body.AddRelativeTorque(new Vector3(MouseY, MouseX, 0));
		}
    }
}