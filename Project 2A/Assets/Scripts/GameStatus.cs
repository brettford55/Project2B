using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    
    //Config
    [SerializeField] int pointsPerApple = 10;
    [SerializeField] Text scoreText;
    [SerializeField] Text livesText;
    //State variables
    [SerializeField] int currentScore = 0;
    [SerializeField]  int startingScore = 0;
    [SerializeField] public static int currentLives = 3;
    [SerializeField] private int startingLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score:" + startingScore.ToString();
        livesText.text = ($"Lives:{startingLives.ToString()} / {startingLives.ToString()}");
        Time.timeScale = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Time.timeScale = 1;
        scoreText.text = "Score:" + currentScore.ToString();
        livesText.text = ($"Lives:{currentLives.ToString()} / {startingLives.ToString()}");
        if (currentLives == 0)
        {
            
            Time.timeScale = 0;

            if (PlayerPrefs.GetInt("Highscore") < currentScore)
            {
               temp = PlayerPrefs.GetInt("Highscore");
               PlayerPrefs.SetInt("Highscore", currentScore);
               currentScore = temp;
            }

            if (PlayerPrefs.GetInt("Highscore2") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore2");
                PlayerPrefs.SetInt("Highscore2", currentScore);
                currentScore = temp;
            }

            if (PlayerPrefs.GetInt("Highscore3") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore3");
                PlayerPrefs.SetInt("Highscore3", currentScore);
                currentScore = temp;
            }


            if (PlayerPrefs.GetInt("Highscore4") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore4");
                PlayerPrefs.SetInt("Highscore4", currentScore);
                currentScore = temp;
            }

            if (PlayerPrefs.GetInt("Highscore5") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore5");
                PlayerPrefs.SetInt("Highscore5", currentScore);
                currentScore = temp;
            }
            if (PlayerPrefs.GetInt("Highscore6") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore6");
                PlayerPrefs.SetInt("Highscore6", currentScore);
                currentScore = temp;
            }
            if (PlayerPrefs.GetInt("Highscore7") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore7");
                PlayerPrefs.SetInt("Highscore7", currentScore);
                currentScore = temp;
            }
            if (PlayerPrefs.GetInt("Highscore8") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore8");
                PlayerPrefs.SetInt("Highscore8", currentScore);
                currentScore = temp;
            }
            if (PlayerPrefs.GetInt("Highscore9") < currentScore)
            {
                temp = PlayerPrefs.GetInt("Highscore9");
                PlayerPrefs.SetInt("Highscore9", currentScore);
                currentScore = temp;
            }
            if (PlayerPrefs.GetInt("Highscore10") < currentScore)
            {
                PlayerPrefs.SetInt("Highscore10", currentScore);
            }

            scoreText.text = "Score:" + startingScore.ToString();
            livesText.text = ($"Lives:{startingLives.ToString()} / {startingLives.ToString()}");
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Game Over");

            currentLives = startingLives;
            if (Input.GetMouseButtonDown(0))
                Time.timeScale = 1;
        }

    }      
        

    
    public void AddToScore()
    {
        currentScore += pointsPerApple;
    }

    public void TakeALife()
    {
        currentLives -= 1;
   
    }

   
}
