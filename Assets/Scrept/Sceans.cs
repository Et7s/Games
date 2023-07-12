using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceans : MonoBehaviour
{
    public void ChangeSceans(int numberScens)
    {
        SceneManager.LoadScene(numberScens);
    }
    public void Exit()
    {
        Application.Quit(); 
    }
}
