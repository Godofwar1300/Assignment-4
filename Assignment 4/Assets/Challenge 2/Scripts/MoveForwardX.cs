using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  * (Christopher Green)
  * (Move Forward.cs)
  * (Assignment 4)
  * (This script is what moves the dog object forward.)
*/


public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}