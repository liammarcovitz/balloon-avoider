using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public static void checkHighscore()
    {
        if (ScoreTracker.score > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", ScoreTracker.score);
        }
        ScoreTracker.score = 0;
    }
}
