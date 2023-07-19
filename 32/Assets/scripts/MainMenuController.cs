using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public float delaySeconds = 5f; // Ana men� ekran�n�n ka� saniye sonra kapanaca��
    void Start()
    {
        // Belirtilen s�re sonra LevelScreen fonksiyonunu �a��racak
        Invoke("LevelScreen", delaySeconds);
    }
    void LevelScreen()
    {
        // Seviye ekran�na ge�i� yapacak
        SceneManager.LoadScene("SampleScene");
    }
}
