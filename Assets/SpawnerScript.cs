using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject bolaPrefab; // Assign your bola prefab in the Unity Editor
    public Transform spawnPoint; // Assign your spawn point in the Unity Editor
    public float spawnDelay = 0.1f; // Adjust the spawn delay as needed


    void Start()
    {
        // Start spawning coroutine
        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        while (true)
        {
            // Spawn bola at the specified position
            Instantiate(bolaPrefab, transform.position, Random.rotation);

            // Wait for a short delay before spawning the next bola
            yield return new WaitForSeconds(spawnDelay);


        }
    }
}