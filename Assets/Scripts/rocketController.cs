﻿using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class rocketController : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public bool despegar = false;

    void FixedUpdate()
    {
        Despegar_nave();
    }

    void Despegar_nave()
    {
        if(despegar)
        {
            // Get the horizontal and vertical axis.
            // By default they are mapped to the arrow keys.
            // The value is in the range -1 to 1
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

            // Make it move 10 meters per second instead of 10 meters per frame...
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;

            float x = Time.time * speed;

            float r = Time.time * speed;

            // Move translation along the object's y-axis
            transform.Translate(0, x, 0);

            // Rotate around our y-axis


            if (transform.position[1] > 50)
            {
                UnityEngine.Debug.Log(transform.position[1]);
                transform.Rotate(r, 0, 0);
            }
            if (transform.position[1] > 70 && transform.position[1] < 72)
            {
                enabled = false;
            }
        }
    }
}
