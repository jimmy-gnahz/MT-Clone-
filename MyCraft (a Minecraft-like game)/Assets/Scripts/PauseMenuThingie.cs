using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuThingie : MonoBehaviour
{
    public GameObject Canvas;

    public void Back2Game()
    {
        Canvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible =false;
        Time.timeScale = 1;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0); //0 loads the menu screen, 1 loads parkour
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Canvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}