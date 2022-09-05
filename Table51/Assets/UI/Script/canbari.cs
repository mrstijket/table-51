using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canbari : MonoBehaviour
{
    float health;
    [SerializeField] float maxHealth = 100;
    public Image canBari;
    public GameObject kalp;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        canBari.fillAmount = health / maxHealth;


        if (Input.GetKeyDown(KeyCode.A))
        {
            if (health > 0)
            {
                health -= 10;
                StartCoroutine(HeartChange());
            }
        }
        if (health <= 0)
        {
            kalp.GetComponent<Image>().color = Color.red;
            health = 0;
            DeathPlayer();
        }
    }

    IEnumerator HeartChange()
    {
        kalp.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(0.5f);
        if (health > 0)
            kalp.GetComponent<Image>().color = Color.white;
    }
    void DeathPlayer()
    {
        Debug.Log("÷ld‹n!!!");
    }
}
