using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//remember, this is 2d so use vector2

public class birbComponent : MonoBehaviour
{
    public bool ded = false;

    //void start is called before the first frame update
    void Start()
    {
        //pause time
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (!ded)
        {
            if (Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.UpArrow) | Input.GetKeyDown(KeyCode.Space) | Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
                //timescale = 1
                Time.timeScale = 1;
            }
        }

        if (ded)
        {
            //when enter or r or space or mouse 0 is pressed, reload the scene
            if (Input.GetKeyDown(KeyCode.R) | Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.Return) | Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    //on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if collides with "bad" tag
        if (collision.gameObject.tag == "bad")
        {
            //set ded to true
            ded = true;
        }
    }
}
