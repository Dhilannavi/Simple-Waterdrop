using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public float destroyDelay = 2f; // Time before destroying the object

    void Start()
    {
        // Invoke the DestroyObject method after a delay
        Invoke("DestroyObject", destroyDelay);
    }

    void DestroyObject()
    {
        // Destroy the object this script is attached to
        Destroy(gameObject);
    }
}

