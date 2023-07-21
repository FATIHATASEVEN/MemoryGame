using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class level5score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public int scoretolevel = 8;
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
            SceneManager.LoadScene("Level6a");
        }
    }
}
