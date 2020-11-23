using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_dogs : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    private float spawnPosX = -50;
    private float spawnRangeZ = 5;
    private float startDelay = 1.1f;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDog", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnRandomDog();
        }
    }

    void SpawnRandomDog()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(14, 21));
        int dogIndex = Random.Range(0, dogPrefabs.Length);
        Instantiate(dogPrefabs[dogIndex], spawnPos, dogPrefabs[dogIndex].transform.rotation);
    }
}
