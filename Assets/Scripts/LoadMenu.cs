using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public void Load(string Level)
    {
        SceneManager.LoadScene("MainMenu");
    }

}
