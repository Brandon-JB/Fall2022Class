using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionScript : MonoBehaviour
{
    public enum ExecutionType { Numbers, Actions, Both, None };
    public ExecutionType type;

    public int[] numbers;
    public UnityEvent[] actions = new UnityEvent[0];

    public void Play()
    {
        Debug.Log("Played Actions");

        if (type == ExecutionType.Both)
        {
            NumbersAndActions();
        }
        else if (type == ExecutionType.Numbers)
        {
            Numbers();
        }
        else if (type == ExecutionType.Actions)
        {
            Actions();
        }
    }

        /*
        First Part: initial condition
        Second part: reoccurence condition
        Third part: increment/decrement
        (n++) = (n +=1) = (n = n + 1)
        for (int n = 0; n < numbers.Length ; n++)
        && AND
        || OR
        ! NOT
        */

    void NumbersAndActions()
    { 
        for (int n = 0; n < actions.Length && n < numbers.Length; n++)
        {
            //Will display nth value of numbers
            Debug.Log(numbers[n]);

            //Will execute nth unityevent
            actions[n].Invoke();
        }
        //When the condition is false, the for loop jumps here
    }

    void Numbers()
    {
        for (int n = 0; n < numbers.Length; n++)
        {
            //Will display nth value of numbers
            Debug.Log(numbers[n]);
        }
    }

    void Actions()
    {
        for (int n = 0; n < actions.Length; n++)
        {
            //Will execute nth unityevent
            actions[n].Invoke();
        }
    }
}
