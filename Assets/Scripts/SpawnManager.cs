using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticlePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    private void Update()
    {

    }

    void SpawnObstacle()
    {
        Instantiate(obsticlePrefab, spawnPos, obsticlePrefab.transform.rotation);
    }
}
