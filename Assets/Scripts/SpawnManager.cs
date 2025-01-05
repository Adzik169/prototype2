using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float spawnPosX = 25;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private int[] directionOptions = { 0, 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        //This method is accually invoking our method that spawns animal at sertain interval of time
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int los = Random.Range(0, 3);
        if (los == 0)
        {
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
        else if (los == 1)
        {
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(3, 16));
            Instantiate(animalPrefab[animalIndex], spawnPos, new Quaternion(0, 180, 0, 180));
        }
        else if (los == 2)
        {
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(3, 16));
            Instantiate(animalPrefab[animalIndex], spawnPos, new Quaternion(0, 45, 0, -45));
        }

    }
}
