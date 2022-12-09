using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public void Play()
    {
        SceneControl.LoadScene(1);
    }

    public void Restart()
    {
        SceneControl.Restart();
    }

    public void NextLevel()
    {
        SceneControl.NextLevel();
    }

    public void SceneLoad(int sceneIndex)
    {
        SceneControl.LoadScene(sceneIndex);
    }
}
