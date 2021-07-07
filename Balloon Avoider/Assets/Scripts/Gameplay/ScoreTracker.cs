using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textObject;

    public static float score = 0;
    private float updateScoreTime = 0.2f;

    void Start()
    {
        InvokeRepeating("updateScore", updateScoreTime, updateScoreTime);
    }

    void Update()
    {
        string text = "Score: " + score.ToString();
        textObject.text = text;
    }

    private void updateScore()
    {
        score += 10;
    }
}
