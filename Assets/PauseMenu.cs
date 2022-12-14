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
    // Will play when the option "Resume" is selected from PauseMenu
    public void Resume()
    {
        // Sets the scene as unactive, so that the panel will disappear
        pauseMenu.SetActive(false);
        // Time will now be normal speed
        Time.timeScale = 1f;
    }
    // Will play when "Home" is selected from the PauseMenu, uses a sceneID integer to trigger the next scene
    public void Home(int sceneID)
    {
        // The time scale is set back to 1, so it is now normal time
        Time.timeScale = 1f;
        // Loads the selected scene, in this case, the menu
        SceneManager.LoadScene(sceneID);
    }
}
