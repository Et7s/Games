using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    [SerializeField] KeyCode keyMenuPaused;
    bool isMenuPaused = false;

    private void Start()
    {
        menuPaused.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }

    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        
        }

        if(isMenuPaused)
        {
            menuPaused.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false); 
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
      
    }

    public void Continue()
    {
        isMenuPaused = false;
    }

    public void MenuSettings()
    {
        Debug.Log("123");
    }

    public void MenuExit()
    {
        SceneManager.LoadScene("Μενώ");

    }
}
