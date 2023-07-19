using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
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
    }
}
