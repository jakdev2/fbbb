using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTub : MonoBehaviour
{
    //on collision with "bad" or ""badmain, destroy the other gameObject involved in the collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bad" || collision.gameObject.tag == "badmain")
        {
            Destroy(collision.gameObject);
        }
    }
}
