using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 


public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI ringScore;

    public static Score singleton;

    private void Awake()
    {
        singleton = this;
    }

    private void Start()
    {
        score = 0;
    }

    public void SetScore(int numToAdd)
    {
        score = score + numToAdd;
        ringScore.text = score.ToString();
    }
}
