using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private Light lightComp;

    void Start()
    {
        lightComp = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        
    }
}
