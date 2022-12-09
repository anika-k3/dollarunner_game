using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    [SerializeField] GameObject playMenu;

    public void Play(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
