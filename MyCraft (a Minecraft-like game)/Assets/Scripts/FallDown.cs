using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
}
