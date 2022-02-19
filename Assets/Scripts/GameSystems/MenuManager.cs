using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//Handles the MainMenu options and displays the current highest score in the main menu
public class MenuManager : MonoBehaviour
{
    public TMP_Text highscore;
    void Start()
    {
        highscore.text = $"High Score To Beat: {ScoreSystem.HighScore}";
    }
    public void Begin()
    {
        SceneManager.LoadScene(1);
    }
    public void End()
    {
        Application.Quit();
        Debug.Log("it works");
    }
}
