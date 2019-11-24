using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public float MouseSensitivity = 100F;
	public Transform PlayerTransform;
	
	private float XRotation;
    private float MouseX;
	private float MouseY;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
		MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
		XRotation -= MouseY;
		XRotation = Mathf.Clamp(XRotation, -90F, 90F);
		transform.localRotation = Quaternion.Euler(XRotation, 0F, 0F);
		PlayerTransform.Rotate(Vector3.up * MouseX);
    }
}