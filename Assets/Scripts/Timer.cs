using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    float timeLeft = 30.0f;
    public GameObject player;
    public TextMeshProUGUI timer;


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Game Over");
        }
        SetTimer();
    }

    public void SetTimer()
    {
        timer.text = timeLeft.ToString();
    }
}
