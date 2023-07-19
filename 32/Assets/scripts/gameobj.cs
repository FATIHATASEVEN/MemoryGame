using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameobj : MonoBehaviour
{
    public void Retry()
    {
        // Oyunu ana menü ekranýna yönlendir
        SceneManager.LoadScene("MainMenu");
    }
}
