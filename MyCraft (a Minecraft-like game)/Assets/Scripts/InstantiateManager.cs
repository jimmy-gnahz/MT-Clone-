using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateManager : MonoBehaviour
{
    public GameObject NewBlock;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(NewBlock);
        }
    }
}