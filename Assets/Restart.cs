using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Creates a game object called restartMenu
    [SerializeField] GameObject restartMenu;

    // Will play when RestartGame is selected from Restart, the sceneID is an integer that will load the allocated scene in the build
    public void RestartGame(int sceneID)
    {
        // Sets the time scale to zero so everything stops
        Time.timeScale = 0f;
        // Loads the next scene
        SceneManager.LoadScene(sceneID);
        // Sets the time back to normal
        Time.timeScale = 1f;
    }
}
