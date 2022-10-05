using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Build.Reporting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Reference to the chracter controller that handles out collisions and movement
    public CharacterController controller;
    //Speed of the player
    public float speed = 1f;
    public Rigidbody reggiebody;
    public float jumpForce;

    void Update()
    {
        //Step 1: Get current position
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        //Step 2: Get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Step 3: Set new position based on input and speed
        //The new value of currentpos in x will be its current value, plus the speed
        //Multiplied by the input (-1 or 1) and time.deltaTime
        currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;
        

        //Step 4: Repeat step 3 with Z
        currentPos.z = currentPos.z + speed * inputY * Time.deltaTime;

        //This will get us the vector of our movement, instead of the new position
        //motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;
        //motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;

        motion = (transform.forward.normalized * speed * inputY * Time.deltaTime)
            + (transform.right * speed * inputX * Time.deltaTime);

        //Step 5: Assign new position
        //transform.position = currentPos;

        //Instead of moving it normally, we can use the character controller for motion
        controller.Move(motion);
    }
}
