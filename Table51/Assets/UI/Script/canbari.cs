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
    public GameObject kalp;
    

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
                kalp.GetComponent<Image>().color = Color.red;
                health =0;
                
                DeathPlayer();
            }
            else
            {
                health -= 10;
                StartCoroutine(HeartChange());
                canText.text = health.ToString();
            }
        }
    }

    IEnumerator HeartChange()
    {
        kalp.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(0.5f);
        if(health >= 0) 
        {
            kalp.GetComponent<Image>().color = Color.white;
        }
        
    }
    void DeathPlayer()
    {
        Debug.Log("÷ld‹n!!!");
    }
}
