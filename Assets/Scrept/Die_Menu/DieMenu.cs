using System;
using System.Collections;
using System.Collections.Generic;
using System.Healths;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{

    PlayerHP health;


    private void Update()
    {
        ActiveDie();
    }

    void ActiveDie() 
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
    }

    public void DieExit()
    {
        SceneManager.LoadScene("Μενώ");
    }
}
