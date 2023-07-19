using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public int scoretolevel2 = 4;

    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void IncrementScore()
    {
        score++;
        UpdateScoreText();
        if (score >= scoretolevel2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
  
}
