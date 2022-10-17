using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        //if the "Jump" input is pressed this frame
        if (Input.GetButton("Jump"))
        {
            //Go to the animator and set the bool parameter call
            //"Grow" to true
            animator.SetBool("Growing", true);
        }
        else
        {
            animator.SetBool("Growing", false);
        }
        //A one-line way of writing it
        //animator.SetBool("Growing", Input.Get("Jump"))

        int X = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        animator.SetInteger("AD", X);

        int Y = Mathf.RoundToInt(Input.GetAxis("Vertical"));
        animator.SetInteger("WS", Y);
    }
}
