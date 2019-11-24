﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	private Rigidbody body;
	public float movementSpeed = 12f;
	
	private Vector3 Movement;
	private float xAxis;
	private float zAxis;

	void ApplyGravity(Attractor attractor) {
        Vector3 dir = attractor.gameObject.transform.position - gameObject.transform.position;
        float magSqr = dir.sqrMagnitude;
        if (magSqr > 0.0001f) {
            body.AddForce(attractor.gravityForce * dir.normalized / magSqr,
                ForceMode.Acceleration);
        }
    }

	void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
		zAxis = Input.GetAxis("Vertical");
		Movement = transform.right * xAxis + transform.forward * zAxis;
		body.AddForce(Movement * movementSpeed);
    }

	void FixedUpdate()
    {
        foreach (Attractor attractor in Ceresil.attractors) {
            ApplyGravity(attractor);
        }
    }
}