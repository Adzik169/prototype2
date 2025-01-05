using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        float spawnX = Random.Range(spawnLimitXLeft, spawnLimitXRight);
        Vector3 spawnPos = new Vector3(spawnX, spawnPosY, 0);
        int whichBall = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[whichBall], spawnPos, ballPrefabs[0].transform.rotation);

        //Use recurion to call a funcion
        Invoke("SpawnRandomBall", Random.Range(3f, 5f));
    }

}
