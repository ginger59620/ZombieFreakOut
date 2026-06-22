using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 3;

    public Animator animator;
    public AudioSource gasp;

    void Start()
    {
        health = maxhealth;
        animator = GetComponent<Animator>();
        gasp = GetComponent<AudioSource>();
    }

    public void TakeDamage(int amout)
    {
        health -= amout; 
        animator.Play("JunoSpotted");
        animator.Play("JunoHurt");
        gasp.Play();
        Debug.Log("Player hit! Health: " + health);
       
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        
    }

}

