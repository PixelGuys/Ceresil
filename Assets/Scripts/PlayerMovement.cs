using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float movementSpeed = 12F;
	
	private Vector3 Movement;
	private float XAxis;
	private float ZAxis;

    void Update()
    {
        XAxis = Input.GetAxis("Horizontal");
		ZAxis = Input.GetAxis("Vertical");
		Movement = transform.right * XAxis + transform.forward * ZAxis;
		controller.Move(Movement * movementSpeed * Time.deltaTime);
    }
}