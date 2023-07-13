using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopka : MonoBehaviour
{

    private void Update()
    {
        MenuTheEnd();
    }

    void MenuTheEnd()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void Exits()
    {
        SceneManager.LoadScene("Μενώ");
    }
}
