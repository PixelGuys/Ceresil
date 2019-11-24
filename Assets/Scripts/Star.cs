using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private Light lightComp;
    public float gravityForce = 0.1f;

    void Start()
    {
        lightComp = gameObject.GetComponent<Light>();
        Ceresil.attractors.Add(new Attractor(gameObject, gravityForce));
    }

    void Update()
    {
        
    }
}
