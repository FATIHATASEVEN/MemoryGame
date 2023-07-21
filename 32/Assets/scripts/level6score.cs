using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level6score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public int scoretolevel = 9;
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
        if (score >= scoretolevel)
        {
            SceneManager.LoadScene("Level7a");
        }
    }
}
