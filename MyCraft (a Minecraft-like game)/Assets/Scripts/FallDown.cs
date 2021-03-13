using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(0); //0 loads the menu screen, 1 loads parkour
    }
}
