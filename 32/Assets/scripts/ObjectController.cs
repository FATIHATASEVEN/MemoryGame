using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectController : MonoBehaviour
{

    private ScoreScript scorescript;
    private void Start()
    {
        scorescript = FindObjectOfType<ScoreScript>();
    }
    private void OnMouseDown()
    {
       
        if (gameObject.CompareTag("green"))
        {
            Destroy(gameObject);
            scorescript.IncrementScore();
        }
        else if (gameObject.CompareTag("red"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
