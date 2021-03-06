using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateManager : MonoBehaviour
{
    public GameObject robotPrefab;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(robotPrefab);
        }
    }
}