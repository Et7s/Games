using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManagre : MonoBehaviour
{
    public static int playerHealth;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthText;
    void Start()
    {
        playerHealth = 100;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthText.text = "" + playerHealth;

        if (gameOver) 
        {
            SceneManager.LoadScene("Level1");
        }
    }

    public static void Damage (int damageCount)
    {
        playerHealth -= damageCount;

        if(playerHealth < 0)
        {
            gameOver = true;
        }
    }
}
