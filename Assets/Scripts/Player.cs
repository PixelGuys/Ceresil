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

    void Update()
    {
        float hor = Input.GetAxis("Horizontal") * speed;
        float ver = Input.GetAxis("Vertical") * speed;
        gameObject.transform.Translate(new Vector3(hor, 0, ver), Space.Self);
        
        // gravity
        GameObject attractor = gameObject.transform.parent.gameObject;
        Vector3 dir = attractor.transform.position - gameObject.transform.position;
        body.AddForce(0.1f * dir);
    }
}
