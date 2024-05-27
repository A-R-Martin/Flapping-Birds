using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LogicManager : MonoBehaviour
{

    public int Score;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public static int HighestScore;
    public Text HighestScoreText;


    [ContextMenu("Inc Score")]
    public void AddScore(int scoreToAdd)
    {
        Score += scoreToAdd;
        ScoreText.text = Score.ToString();
    }

    public void HighScore()
    {

        if (Score > HighestScore)
        {
            HighestScore = Score;
            PlayerPrefs.SetInt("HighScore", HighestScore);
        }
    }

    public void DisplayHighScore()
    {
        int highscore = PlayerPrefs.GetInt("HighScore");

        HighestScoreText.text = highscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

}
