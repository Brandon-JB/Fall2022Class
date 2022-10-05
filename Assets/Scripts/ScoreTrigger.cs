using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreTrigger : MonoBehaviour
{
    public TextMeshProUGUI testingText;
    static int score = 0;

    void OnTriggerEnter(Collider other)
    {
        //We check if the other collider has the tag "Amogus" on its object
        if (other.gameObject.tag == "Amogus")
        {
            score++;
            //The same as saying score = score + 1;

            //Debug.Log(score);
            testingText.text = score.ToString();
        }
    }
}
