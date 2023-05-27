using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectsToSpawn;   
    public float spawnInterval = 2f;
    private float yPosition = -3f;

    private float spawnTimer;             

    private void Start()
    {
        SpawnRandomObject();
        spawnTimer = spawnInterval;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnRandomObject();
            spawnTimer = spawnInterval;
        }
    }

    private void SpawnRandomObject()
    {
        yPosition += 7f;
        int randomIndex = Random.Range(0, objectsToSpawn.Length);

        Instantiate(objectsToSpawn[randomIndex], new Vector3(transform.position.x, yPosition, transform.position.z), Quaternion.identity);
    }
}
