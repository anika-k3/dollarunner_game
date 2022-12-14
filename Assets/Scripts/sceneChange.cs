using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Creates a game object to change the scene
    [SerializeField] private string loadScene;

    // When there is a collision between object, this plays
    void OnTriggerEnter(Collider other)
{
        // If it collides with the game object with the tag called "Player", then it will debug that a collision has occured
    if (other.gameObject.CompareTag("Player"))
    {
            Debug.Log("Collision with Player Occured");
    }
}

}
