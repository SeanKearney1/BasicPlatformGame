using System;
using Unity.Mathematics;
using UnityEngine;

public class Morphius : MonoBehaviour
{
    public Vector3 Scale;
    public int MorphinTime = 2;
    public int MorphinScale = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float morph = (Mathf.Sin(Time.time * MorphinTime) * MorphinScale)/2 + 1.5f;

        Scale.x = morph;
        Scale.y = MorphinScale + 1 - morph;
        transform.localScale = Scale; 
    }
}
