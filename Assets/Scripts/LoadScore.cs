using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class LoadScore : MonoBehaviour
{
    public float savedScore;
    public TextMeshProUGUI score;

    private void Start()
    {
        SetScoreText();
        SetScore();

    }

    void SetScoreText()
    {
        savedScore = PlayerPrefs.GetFloat("Score", Score.singleton.score);
    }

    void SetScore()
    {
        score.text = savedScore.ToString();
    }
}
