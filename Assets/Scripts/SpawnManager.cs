using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticlePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerControllerScript;

    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obsticlePrefab, spawnPos, obsticlePrefab.transform.rotation);
        }
    }
}
