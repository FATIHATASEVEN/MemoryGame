using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level7controller : MonoBehaviour
{
    public float delaySeconds = 5f;
    void Start()
    {
        Invoke("LevelScreen", delaySeconds);
    }
    void LevelScreen()
    {
        SceneManager.LoadScene("level7b");
    }
}
