using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxhealth = 1;

    public Animator animator;

    void Start()
    {
        health = maxhealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int amout)
    {
        health -= amout;
        animator.Play("Death");
        Debug.Log("zombie hit! Health: " + health);

        if (health <= 0)
        {
            animator.Play("Death");
            Destroy(gameObject);
        }
    }
}
