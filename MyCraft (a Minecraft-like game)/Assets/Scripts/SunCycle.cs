using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{

    public int rotatespeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.01f, Space.World);
    }
}
