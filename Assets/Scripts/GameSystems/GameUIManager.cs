using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Handles all Text in the scene that display changing variables such as score and lives left
public class GameUIManager : MonoBehaviour
{
    public TMP_Text ScoreDisplay, LivesDisplay, MultiplerDisplay, HighScoreDisplay,EndResult;
    private int count1, count2, count3;
    // Start is called before the first frame update
    void Start()
    {
        count2 = ScoreSystem.Lives;
        count3 = ScoreSystem.Multipler;
        ScoreDisplay.text = $"Score: {ScoreSystem.Score}";
        LivesDisplay.text = $"Lives: {ScoreSystem.Lives}";
        MultiplerDisplay.text = $"Multipler: {ScoreSystem.Multipler}";
    }

    // Update is called once per frame
    void Update()
    {

        if(ScoreSystem.Score != count1)
        {
            ScoreDisplay.text = $"Score: {ScoreSystem.Score}";
            count1 = ScoreSystem.Score;
        }
        if (ScoreSystem.Lives != count2)
        {
            LivesDisplay.text = $"Lives: {ScoreSystem.Lives}";
            count2--;
        }
        if (ScoreSystem.Multipler != count3)
        {
            MultiplerDisplay.text = $"Multipler: {ScoreSystem.Multipler}";
            count3++;
        }
         HighScoreDisplay.text = $"High Score: {ScoreSystem.HighScore}";
        if (ScoreSystem.Lives == 0)
        {
            EndResult.text = $"Your Result was: {ScoreSystem.Score}";
        }
    }
}
