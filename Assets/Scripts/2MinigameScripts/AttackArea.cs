using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public int damage = 3;
    public Health health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
            health.TakeDamage(damage);
    }
}
