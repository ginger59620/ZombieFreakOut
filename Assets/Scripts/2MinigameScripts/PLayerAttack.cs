using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAttack : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Zombie")
        {
            Health health = collider.gameObject.GetComponent<Health>();
            health.TakeDamage(damage);
        }
    }
}

