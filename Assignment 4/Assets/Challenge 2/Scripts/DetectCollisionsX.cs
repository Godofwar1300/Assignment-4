using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  * (Christopher Green)
  * (DetectCollisions.cs)
  * (Assignment 4)
  * (This script is what dectecs when collisions are made between the dog and ball objects.)
*/

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
