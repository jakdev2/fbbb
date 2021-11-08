using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//remember, this is 2d so use vector2

public class birbComponent : MonoBehaviour
{
    private bool ded = false;
    public int points;
    public int highscore;
    public int newHighscore;

    //void start is called before the first frame update
    void Start()
    {
        //pause time
        Time.timeScale = 0;

        ded = false;
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

            if (Input.GetKeyDown(KeyCode.Return) | Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 0;
            }
        }

        if (ded)
        {
            //when enter or r or space or mouse 0 is pressed, reload the scene
            if (Input.GetKeyDown(KeyCode.R) | Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.Return) | Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (points > highscore)
            {
                highscore = points;
                Debug.Log("New Highscore: " + highscore);
            }

            if(PlayerPrefs.GetInt("score")<=highscore);
            PlayerPrefs.SetInt("highscore", highscore);
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!ded)
        {
            //add points
            points++;
            //print points to console
            Debug.Log("Points: " + points);
        }
        if (ded)
        {

        }
    }

    void Awake()
    {
        //load newhighscore
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }

    //save highscore
    public void highscorebruh()
    {

    }
}