using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarController : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float x = Time.time * Input.GetAxis("Horizontal");
        float z = Time.time * Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(x, 0f, z);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("Parar");
        }
        

        // Move translation along the object's y-axis
        transform.Translate(x, 0f, z);
       
    }
}
