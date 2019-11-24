using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    float deg = 0;
    public float starDistance = 100;
    public float speed = 0.01f;
    public float gravityForce = 0.1f; // the force applied on other objects attracted to this body.

    void Start()
    {
        Ceresil.attractors.Add(new Attractor(gameObject, gravityForce));
    }

    void Update()
    {
        Vector3 pos = new Vector3(Mathf.Cos(deg) * starDistance, 0, Mathf.Sin(deg) * starDistance);
        gameObject.transform.localPosition = pos;
        gameObject.transform.Rotate(0f, 0.3f, 0f);
        deg += speed;
    }
}
