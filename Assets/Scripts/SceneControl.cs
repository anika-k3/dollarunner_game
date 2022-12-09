using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public static void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public static void Restart()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void NextLevel()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
