using UnityEngine;
using System.Collections.Generic;
using System;

public class dna : MonoBehaviour
{
    public int speed;
    void FixedUpdate()
    {
        // not up
        transform.Rotate(Vector3.back * Time.deltaTime * speed);
    }
}