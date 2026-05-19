using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    [Header("Collider")]
    public new BoxCollider2D collider;

    [Header("Health")]
    public int damage = 1;
    public PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();

            if (playerMovement.isHidden == false)
            {
                playerHealth.TakeDamage(1);
            }
        }
    }
}
