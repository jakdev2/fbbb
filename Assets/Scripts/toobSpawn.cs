using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toobSpawn : MonoBehaviour
{
    //tob
    public GameObject tob;

    //timer
    public float timer = 1;

    void Update()
    {
        //increase timer by 1 every second
        timer += Time.deltaTime;
        //if timer is equal or greater than 2
        if (timer >= 1)
        {
            //spawn tob at x = 9.5, and y between -2.5 and 3
            Instantiate(tob, new Vector2(9.5f, Random.Range(-2.5f, 3)), Quaternion.identity);

            //reset the timer
            timer = 0;
        }

    }
}
