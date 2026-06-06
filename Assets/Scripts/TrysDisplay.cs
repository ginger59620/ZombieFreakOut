using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrysDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite lostTry;
    public Sprite fullTry;
    public Image[] trys;

    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxhealth;

        for (int i = 0; i < trys.Length; i++)
        {
            if(i < health)
            {
                trys[i].sprite = fullTry;
            }
            else
            {
                trys[i].sprite = lostTry;
            }
            if (i < maxHealth)
            {
                trys[i].enabled = true;
            }
            else
            {
                trys[i].enabled = false;
            }
        }
    }
}
