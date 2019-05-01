using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScore : MonoBehaviour
{
    void Update()
    {
        PlayerPrefs.SetFloat("Score", Score.singleton.score);
    }
}
