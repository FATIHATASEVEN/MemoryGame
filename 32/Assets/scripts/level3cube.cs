using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3cube : MonoBehaviour
{
    private level3score scorescript;

    private void Start()
    {
        scorescript = FindObjectOfType<level3score>();
        // Debug.Log("atama yapýldý");
    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("green"))
        {
            Destroy(gameObject);
            scorescript.IncrementScore();
            /* if(scorescript.scoretolevel == 4)
             {
                 SceneManager.LoadScene("Level4a");
             }*/
        }
        else if (gameObject.CompareTag("red"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
