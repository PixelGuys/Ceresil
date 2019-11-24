using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor
{
    public GameObject gameObject;
    public float gravityForce;

    public Attractor(GameObject gameObject, float gravityForce) {
        this.gameObject = gameObject;
        this.gravityForce = gravityForce;
    }
}
