using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Creates a class called ResumeMenu, which will be used to resume the game
public class ResumeMenu : MonoBehaviour
{
    // Creates a game object called "resumeMenu"
    [SerializeField] GameObject resumeMenu;

    // Will play when the option "Resume" is selected from the ResumeMenu, uses an integer called sceneID which is allocated to a scene number in the build
    public void Resume(int sceneID)
    {
        // Loads the scene selected 
        SceneManager.LoadScene(sceneID);
        //
        Time.timeScale = 1;
    }
}
