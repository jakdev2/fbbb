using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toobSpawn : MonoBehaviour
{
    //tob
    public GameObject tob;

    //2 second timer
    public float timer = 0;

    void Update()
    {
        //increase timer by 1 every second
        timer += Time.deltaTime;
        //if timer is equal or greater than 2
        if (timer >= 2)
        {
            //spawn tob at x = 5.5, and y between -5 and 5
            Instantiate(tob, new Vector2(5.5f, Random.Range(-5, 5)), Quaternion.identity);

            //reset the timer
            timer = 0;
        }

    }
}
