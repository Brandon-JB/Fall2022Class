    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    public float speed;

    //Length of the raycast
    public float skinWidth = 0.1f;

    public LayerMask skinLayers;

    // Update is called once per frame
    void Update()
    {
        //We get the user input and store it in local variables
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //We multiply the input by speed and time delta time to determine how much the player should move this frame.
        x = x * speed * Time.deltaTime;
        y = y * speed * Time.deltaTime;

        //if the function CheckForWall returns true, after being sent the direction and range, don't move the player in that direction
        if (CheckForWall(this.transform.right * x, skinWidth) == false)
        {
            x = 0;
        }
        if (CheckForWall(this.transform.up * y, skinWidth) == false)
        {
            y = 0;
        }

        this.transform.localPosition = this.transform.localPosition + new Vector3 (x, y, 0);
        /*Equivalent to this:
         this.transform.position = new Vector3(this.transform.position.x + x,
         this.transform.position.y + y, this.transform.position.z + 0);
        */
    }

    bool CheckForWall(Vector3 direction, float range)
    {
        RaycastHit info;

        //this will draw the ray in our editor for debugging purposes
        Debug.DrawRay(this.transform.position, direction * range * 2, Color.blue, 1);

        //If we can cast a ray from the position of this transform, in the direction specified
        if (Physics.Raycast(this.transform.position, direction, out info, range, skinLayers))
        {
            Debug.Log(info.transform.name);
            return false;
        }
        else
        {
            return true;
        }
    }
}
