using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHighscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private float score;

    void Start()
    {
        score = PlayerPrefs.GetFloat("highscore");
        text.text = "Personal Best: " + score.ToString();
    }

    void Update()
    {

    }
}
