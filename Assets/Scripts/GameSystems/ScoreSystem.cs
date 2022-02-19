using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The variables for all ui and game scoring mechanics
public class ScoreSystem : MonoBehaviour
{
    public static int Score;
    private static int ScoreChecker;
    public static int Multipler;
    public static int CountForMultipler;
    public static int Lives;

    public static int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        Lives = 3;
        Score = 0;
        Multipler = 1;
        CountForMultipler = 25;
    }
    void Update()
    {
        //Gives the player one extra life for every 1000 points earned
        if(ScoreChecker>1000)
        {
            Lives++;
            ScoreChecker = 0;
        }
        //Changes the HighScore when the player beat their personal best
        if (Score > HighScore)
        {
            HighScore = Score;
        }

    }
    //Resets the variables to starting point to punish the player that died
    public static void Respawn()
    {
        CountForMultipler = 25;
        Multipler = 1;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //To increase the multipler since the player is surviving long enough
        if(CountForMultipler == 0)
        {
            CountForMultipler = 25;
            Multipler += 1;
        }
        
    }
    //Gets called from all other enemy types to change the current score
    public static void UpdateScore(EnemyType type)
    {
        switch (type)
        {
            case EnemyType.Wanderer:
                CountForMultipler -= 1;
                ChangeScore(1);
                break;
            case EnemyType.Seeker:
                CountForMultipler -= 1;
                ChangeScore(2);
                break;
            case EnemyType.BlackHole:
                CountForMultipler -= 1;
                ChangeScore(5);
                break;
            case EnemyType.Chaser:
                CountForMultipler -= 1;
                ChangeScore(1);
                break;
            default:
                break;
        }
    }
    //The function to change the score and ScoreChecker for extra lives
    public static void ChangeScore(int value)
    {
        Score += (value * Multipler);
        ScoreChecker += (value * Multipler);
    }
}
