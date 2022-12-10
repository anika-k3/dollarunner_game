using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
