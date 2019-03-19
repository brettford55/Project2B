using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text highScoreText;
    public Text highScore2Text;
    public Text highScore3Text;
    public Text highScore4Text;
    public Text highScore5Text;
    public Text highScore6Text;
    public Text highScore7Text;
    public Text highScore8Text;
    public Text highScore9Text;
    public Text highScore10Text;


    // Start is called before the first frame update
    void Start()
    {

        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        highScore2Text.text = "Highscore 2: " + PlayerPrefs.GetInt("Highscore2");
        highScore3Text.text = "Highscore 3: " + PlayerPrefs.GetInt("Highscore3");
        highScore4Text.text = "Highscore 4: " + PlayerPrefs.GetInt("Highscore4");
        highScore5Text.text = "Highscore 5: " + PlayerPrefs.GetInt("Highscore5");
        highScore6Text.text = "Highscore 6: " + PlayerPrefs.GetInt("Highscore6");
        highScore7Text.text = "Highscore 7: " + PlayerPrefs.GetInt("Highscore7");
        highScore8Text.text = "Highscore 8: " + PlayerPrefs.GetInt("Highscore8");
        highScore9Text.text = "Highscore 9: " + PlayerPrefs.GetInt("Highscore9");
        highScore10Text.text = "Highscore 10: " + PlayerPrefs.GetInt("Highscore10");





    }


}
