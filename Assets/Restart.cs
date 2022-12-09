using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] GameObject restartMenu;

    public void RestartGame(int sceneID)
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(sceneID);
        Time.timeScale = 1f;
    }
}
