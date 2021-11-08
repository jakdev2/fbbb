using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    public GameObject birb;
    public int highscore;

    void Update()
    {   //if the birb gameobject's script's point value is greater than highscore
        if (birb.GetComponent<birbComponent>().points > highscore)
        {
            highscore++;
            Debug.Log("New Highscore: " + highscore);
        }
    }

    //dont destroy on load
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
