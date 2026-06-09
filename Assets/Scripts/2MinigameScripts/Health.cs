using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxhealth = 1;

    void Start()
    {
        health = maxhealth;
    }

    public void TakeDamage(int amout)
    {
        health -= amout;
        Debug.Log("zombie hit! Health: " + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
