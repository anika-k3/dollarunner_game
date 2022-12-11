using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    [SerializeField] private string loadScene;

    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
            Debug.Log("It is working.");
    }
}

}
