using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created a class for the movement of the stranger
public class move : MonoBehaviour
{
    // Sets the speed of the stranger to 2
    public float speed = 2;

    void Update()
    {
        // Transforms the stranger's location on the game by multiplying the vector that moves to the left, by the speed and time the game is running at (ex. when paused it will be zero, causing the stranger to stop moving)
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
