using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class canbari : MonoBehaviour
{
    float health;
    float maxHealth = 100;
    public Image canBari;
    public TextMeshProUGUI canText;
    

    void Start()
    {
        health = maxHealth;
        canText.text=health.ToString();
    }

    void Update()
    {
        canBari.fillAmount = health / maxHealth;
        

        if (Input.GetKeyDown(KeyCode.A))
        {
           
            if (health <= 0)
            {
                health=0;
                DeathPlayer();
            }
            else
            {
                health -= 10;
                canText.text = health.ToString();
            }
        }
    }

    void DeathPlayer()
    {
        Debug.Log("ÖldÜn!!!");
    }
}
