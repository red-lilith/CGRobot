using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFreeAnim : MonoBehaviour
{

    Animator anim;
    float speed = 10.0f;
    Vector3 rot = Vector3.zero;

    float rotSpeed = 80f;
   Rigidbody playerRB;

    void Start()
    {
       
        playerRB = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        gameObject.transform.eulerAngles = rot;
        playerRB.transform.Rotate(rot);
    }

    // Update is called once per frame
    void Update()
    {

        CheckKey();
        gameObject.transform.eulerAngles = rot;
        //Walk Animation Zombie
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Animate Walk
            anim.SetBool("Walk_Anim", true);

        }

        //Stop Zombie Animation
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Walk_Anim", false);
        }

    }

    void FixedUpdate()
    {
        //Move Code
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Move Player Forward
        if (Input.GetKey(KeyCode.W))
        {

            //playerRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);
            //transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);

            playerRB.AddForce(transform.forward*800);
            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);

        }
    }

    void CheckKey()
    {

        // Rotate Left
        if (Input.GetKey(KeyCode.A))
        {
            rot[1] -= rotSpeed * Time.fixedDeltaTime;
        }

        // Rotate Right
        if (Input.GetKey(KeyCode.D))
        {
            rot[1] += rotSpeed * Time.fixedDeltaTime;
        }

        // Roll
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anim.GetBool("Roll_Anim"))
            {
                anim.SetBool("Roll_Anim", false);
            }
            else
            {
                anim.SetBool("Roll_Anim", true);
            }
        }

        // Close
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!anim.GetBool("Open_Anim"))
            {
                anim.SetBool("Open_Anim", true);
            }
            else
            {
                anim.SetBool("Open_Anim", false);
            }
        }
    }
}
