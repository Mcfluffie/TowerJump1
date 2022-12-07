using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            isPaused = !isPaused;
            LPauseGame();
        }
    }

    public void LPauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
            //Show pause menu or display pause message
        }
      
    }


    public void ResumeGame()
    {
        Time.timeScale = 1;
        //Hide pause menu or remove pause message
    }
}
