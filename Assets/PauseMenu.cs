using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause(int sceneID)
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(sceneID);
        Time.timeScale = 0;
    }
}
