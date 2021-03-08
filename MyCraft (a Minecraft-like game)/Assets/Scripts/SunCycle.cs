using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{

    public int rotatespeed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(3, rotatespeed, 1, Space.World); //the 3 is originally 1
    }
}
