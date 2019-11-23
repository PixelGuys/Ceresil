using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    float deg = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = new Vector3(Mathf.Cos(deg) * 36, 0, Mathf.Sin(deg) * 36);
        gameObject.transform.localPosition = pos;
        gameObject.transform.Rotate(0, 0.3f, 0.1f);
        deg += 0.01f;
    }
}
