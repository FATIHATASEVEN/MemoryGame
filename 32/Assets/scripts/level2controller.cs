using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2controller : MonoBehaviour
{
    public float delaySeconds = 5f; // Ana menü ekranýnýn kaç saniye sonra kapanacaðýný belirten kod
    void Start()
    {
        // Belirtilen süre sonra LevelScreen fonksiyonunu çaðýracak
        Invoke("LevelScreen", delaySeconds);
    }
    void LevelScreen()
    {
        // Seviye ekranýna geçiþ yapacak
        SceneManager.LoadScene("level2game");
    }
}
