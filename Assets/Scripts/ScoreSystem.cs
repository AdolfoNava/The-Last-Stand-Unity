using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static int Score = 0;
    public static int Multipler = 1;
    public static int CountForMultipler;
    public static int Lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CountForMultipler == 0)
        {
            CountForMultipler = 25;
            Multipler += 1;
        }
    }
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
    public static void ChangeScore(int value)
    {
        Score += (value * Multipler);
    
    }
}
