using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    // Creates a game object called playMenu
    [SerializeField] GameObject playMenu;

    // When "Play" is selected from PlayMenu, the scene will change based onto the integer set in the build
    public void Play(int sceneID)
    {
        // Loads allocated scene
        SceneManager.LoadScene(sceneID);
    }
}