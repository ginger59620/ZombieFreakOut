using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 3;

    public Animator animator;

    void Start()
    {
        health = maxhealth;
    }

    public void TakeDamage(int amout)
    {
        health -= amout;
        Debug.Log("Player hit! Health: " + health);

        if (health <= 0)
        {
            animator.SetBool("isSpotted", true);
            Destroy(gameObject);
        }
        else
        {
            animator.SetBool("isSpotted", false);
        }
    }

}

