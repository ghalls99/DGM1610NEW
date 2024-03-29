﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnDelay = 2f;
    private float repeatRate = 2;
    public PlayerControl playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", spawnDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
          Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
