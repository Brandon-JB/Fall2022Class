using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwomp : MonoBehaviour
{
    //Will work only if object is trigger
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
        //if (collision.gameObject.tag == "Player")
        //{
            //Destory the other object
            //Destroy(collision.gameObject);
        //}
    //}

    //Works off of object colliders
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
