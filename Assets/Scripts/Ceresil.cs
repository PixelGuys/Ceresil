using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceresil : MonoBehaviour
{

    public static List<Attractor> attractors = new List<Attractor>();

    public static List<Attractor> GetAttractors(GameObject org) {
        List<Attractor> objAttract = new List<Attractor>();
        foreach (Attractor obj in attractors) {
            objAttract.Add(obj);
        }
        return objAttract;
    }

    public void Start()
    {
        
    }

    public void Update()
    {
        
    }
}
