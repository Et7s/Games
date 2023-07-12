using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class PlayerHP : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public GameObject DieMenuu;
    public TextMeshProUGUI teext;


    private void Start()
    {
        DieMenuu.SetActive(false);
    }

    private void Update()
    {
        teext.SetText("Çהמנמגüו : " + health.ToString());
    }

    public void TakeHit(int damageee)
    {
        health -= damageee;

        
        if (health <= 0)
        {
            DieMenuu.SetActive (true);
        }
    }
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    
    
}


