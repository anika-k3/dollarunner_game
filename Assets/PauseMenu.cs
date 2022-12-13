using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Creates a class called PauseMenu, which will be used to pause the game
public class PauseMenu : MonoBehaviour
{
    // Creates a game object called pauseMenu
    [SerializeField] GameObject pauseMenu;

    // Will play when the option "Pause" is selected from PauseMenu, uses an integer called sceneID which is allocated to a scene number in the build
    public void Pause()
    {
        // sets the pause menu as active when clicked, so that the hidden panel will show up
        pauseMenu.SetActive(true);
        // Everything in the background stops as time gets set to zero
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
