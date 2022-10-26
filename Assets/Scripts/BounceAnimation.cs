using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAnimation : MonoBehaviour
{

    public Animator animator;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //animator.SetBool("Bounce", true);
            animator.Play("Bounce");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
