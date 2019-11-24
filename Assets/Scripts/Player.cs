using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 0.1f;
    Rigidbody body;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    void ApplyGravity(Attractor attractor) {
        Vector3 dir = attractor.gameObject.transform.position - gameObject.transform.position;
        float magSqr = dir.sqrMagnitude;
        if (magSqr > 0.0001f) {
            body.AddForce(attractor.gravityForce * dir.normalized / magSqr,
                ForceMode.Acceleration);
        }
    }

    void Update() {
        float hor = Input.GetAxis("Horizontal") * speed;
        float ver = Input.GetAxis("Vertical") * speed;
        gameObject.transform.Translate(new Vector3(hor, 0, ver), Space.Self);
    }

    void FixedUpdate()
    {
        foreach (Attractor attractor in Ceresil.attractors) {
            ApplyGravity(attractor);
        }
    }
}
