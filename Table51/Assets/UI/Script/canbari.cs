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
    

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        canText.text=health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        canBari.fillAmount = health / maxHealth;
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            health -= 10;
            canText.text = health.ToString();
            if (health <= 0)
            {
                DeathPlayer();
            }
        }
    }

    void DeathPlayer()
    {
        Debug.Log("Oldun!!!");
    }
}
