﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  * (Christopher Green)
  * (PlayerController.cs)
  * (Assignment 4)
  * (This script is what spawns the dog object when the space bar is pressed.)
*/


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float nextSpawn = 0f;
    private float spawnRate = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
