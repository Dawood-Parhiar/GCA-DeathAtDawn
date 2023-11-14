using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        // Load the first level
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
    public void ControlsMenu()
    {
        // Load the controls menu
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
