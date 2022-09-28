using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    int score = 0;
    void OnTriggerEnter(Collider other)
    {
        //We check if the other collider has the tag "Amogus" on its object
        if (other.tag == "Amogus")
        {
            score++;
            //The same as saying score = score + 1;

            Debug.Log(score);
        }
    }
}
