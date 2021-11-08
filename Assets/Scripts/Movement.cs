using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//remember, this is 2d so use vector2

public class Movement : MonoBehaviour
{
    // update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.left * 3 * Time.deltaTime);
    }

    //when it collides with "square"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "square")
        {
            //destroy this gameobject
            Destroy(gameObject);
        }
    }
}